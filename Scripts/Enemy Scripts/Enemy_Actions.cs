using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Actions : MonoBehaviour
{
    public float speed;//speed variable to calculate AI speed
    public Enemy_Operator states;//gets the statemachine enums  
    public Transform Target;//position used to target the player object 
    public TrailRenderer tr;//Trail renderer is for the charge trail when AI speeds up for attacking 
    public Player_Detection PD;//Gets the boolean that restarts the StateMachine Coroutine

    void Start()
    {
      Target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();//gets player tag for the Target transform position 
    }

//STATE MACHINE ENUM: CALLS MOVING STATES WITH THE ALLOCATED PARAMETERS FOR THE TWO MAIN STATES BEING USED TO FOLLOW AND ATTACK THE PLAYER 
 public IEnumerator StateMachine()
 {
      Moving(true, false);//Can chase but cannot attack
      yield return new WaitForSeconds(2f);//chases player for two seconds
      Moving(false, true);//Can attack but cannot move at normal speed
      yield return new WaitForSeconds(1f);//attacks for one second 
      Moving(true, false);//Can chase but attack is set back to false
      PD.IsAttacking = false;//obtains Is attacking boolean from the Player_Detection Script so the coroutine can restart again
 }
//END OF SEQUENCE

//INDEX METHODS USED FOR THE ENUM STATES 

 public void Idle()//IDLE: AI DOES NOT MOVE WHEN PLAYER IS NOT IN SIGHT 
{
  speed = 0f;//speed is null
}

public void AIFollow()//AI FOLLOW: 
{
    tr.emitting = false;//trail is not visible
    speed = 1f;//speed is equal to one
    transform.position = Vector2.MoveTowards(transform.position, Target.position,speed*Time.deltaTime);//enemy position will move towards player using the speed it has.
}
public void AIAttack()
{
  AudioSourceController.Instance.PlaySFX("Dash");
    tr.emitting = true;//trail is visible
    speed = 3f;//speed is equal to three
    transform.position = Vector2.MoveTowards(transform.position, Target.position,speed*Time.deltaTime);//enemy position will move towards player using the speed it has.
}

//this method is used to check if the AI can move or attack
public void Moving(bool CanMove, bool CanAttack)
{
//CAN MOVE SWITCH STATEMENT
  switch(CanMove)//switch statement used to switch states
  {
    case true:
    states.Enemy_Behaviour = Enemy_Operator.Enemy.Chase;//if AI can move then AI can chase the player
    break;
    case false:
    states.Enemy_Behaviour = Enemy_Operator.Enemy.Attack;//if AI can not move, AI will get aggressive
    break;
  }
  //CAN ATTACK SWITCH STATEMENT
    switch(CanAttack)//switch statement used to switch states
  {
    case true:
    states.Enemy_Behaviour = Enemy_Operator.Enemy.Attack;//if AI can attack then AI can charge toward the player
    break;
    case false:
    states.Enemy_Behaviour = Enemy_Operator.Enemy.Chase;//if AI can not attack, AI will return to the chase state.
    break;
  }

}
}
