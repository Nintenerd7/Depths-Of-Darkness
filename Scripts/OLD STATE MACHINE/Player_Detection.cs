using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Detection : MonoBehaviour
{
    public Patrol condition;
    bool Is_In_Sight = false;
    public Enemy_Operator states;
   private void Update()
   {
     if(Is_In_Sight)
     {
       StartCoroutine(ChangeStates());
     }
     else
     {
       states.Enemy_Behaviour = Enemy_Operator.Enemy.idle;
     }
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

   public IEnumerator ChangeStates()
   { 
      condition.Moving(true);
      yield return new WaitForSeconds(3);
      condition.Attack(true);
      yield return new WaitForSeconds(0.1f);
      condition.Attack(false);
   }

}
