using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Detection : MonoBehaviour
{
    public Patrol condition;
   public bool Is_In_Sight = false;
    public Enemy_Operator states;
    public bool Can_Attack;
   private void Update()
   {
     CanBeSeen();
   }
   private void FixedUpdate()
   {
     RaycastHit2D ray = Physics2D.Raycast(transform.position, condition.Target.position - transform.position);

     if(ray.collider != null)
     {
      Is_In_Sight = ray.collider.CompareTag("Player");
      if(Is_In_Sight)
      {
        Debug.DrawRay(transform.position, condition.Target.position - transform.position, Color.green);
      }
      else
      {
        Debug.DrawRay(transform.position, condition.Target.position - transform.position, Color.red);
      }
     }
   }

 public void Change()
 {
     states.Enemy_Behaviour = Enemy_Operator.Enemy.Chase;
 }

public void CanBeSeen()
{
      if(Is_In_Sight)
     {
      Change();
     }
     else
     {
       states.Enemy_Behaviour = Enemy_Operator.Enemy.idle;
     }
}

}
