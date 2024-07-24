using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Detection : MonoBehaviour
{
    public Enemy_Actions condition;
   public bool Is_In_Sight = false;
    public Enemy_Operator states;
    public bool IsAttacking;
    public LayerMask LayersToHit;

    private void Start()
    {
      IsAttacking = false;//starts off as false
    }
   private void Update()
   {
     CanBeSeen();//called Can be seen to the update method
   }

   //RAY CAST LINE LOGIC
   private void FixedUpdate()
   {
    //Ray variable is declared in the fixed update function
     RaycastHit2D ray = Physics2D.Raycast(transform.position, condition.Target.position - transform.position);

     if(ray.collider != null)//if rays collider is not null 
     {
      Is_In_Sight = ray.collider.CompareTag("Player");//Ray cast line hits the player after being in sight 
      if(Is_In_Sight)//if player is in sight 
      {
        Debug.DrawRay(transform.position, condition.Target.position - transform.position, Color.green);//raycast line is green in the gizmos tab, player is visible
      }
      else
      {
        Debug.DrawRay(transform.position, condition.Target.position - transform.position, Color.red);//raycast line is green in the gizmos tab, player is not visible
      }
     }
   }

public void CanBeSeen()//CAN BE SEEN METHOD IS USED TO DETERMINE WHAT STATE THE AI WILL BE IN ONCE THE RAYCAST 
{
      if(Is_In_Sight)//if is in sight
     {
      if(!IsAttacking)  //checks if player is also not attacking
      {
        IsAttacking = true;//player is now attacking.
        StartCoroutine(condition.StateMachine());//begins chase sequence
      }
     }
     else//if player is not in sight 
     {
       states.Enemy_Behaviour = Enemy_Operator.Enemy.idle;//player is idle 
     }
}

}
