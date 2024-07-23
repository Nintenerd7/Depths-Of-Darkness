using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    //variables
    public float[] CoolDown = new float [3];
    public float speed;
    public Enemy_Operator states;
    public Transform Target;
    public Transform returnPos;
    public TrailRenderer tr;
    public Player_Detection PD;
    void Start()
    {
      Target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    //update
    public void Idle()
    {
      Debug.Log("Idle");
      Moving(false);
    }

    public IEnumerator Chase()
    {
      PD.Can_Attack = true;
      Moving(true);
      speed = 1f;
      tr.emitting = false;
      transform.position = Vector2.MoveTowards(transform.position, Target.position,speed*Time.deltaTime);//enemy position will move towards player using the speed it has.
      yield return new WaitForSeconds(3f);
      speed += 3f;
      yield return new WaitForSeconds(0.4f);
      speed = 0f;
      yield return new WaitForSeconds(1f);
      speed = 1f;
      
    }
 public IEnumerator StateMachine()
 {
   while(true)
   {
     Debug.Log("Is chashing");
     StartCoroutine(Chase());
   }
 }

public void Moving(bool CanMove)
{
  if(CanMove)
  {

    speed = 1f;
    tr.emitting = false;
    states.Enemy_Behaviour = Enemy_Operator.Enemy.Chase;
  }
  else
  {
   speed = 0f;
  }
}
}
