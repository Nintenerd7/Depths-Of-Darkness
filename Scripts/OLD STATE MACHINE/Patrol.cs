using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    //variables
    public float speed;
    public Enemy_Operator states;
    public Transform Target;
    public Transform returnPos;
    public TrailRenderer tr;

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

    public void Chase()
    {
      Moving(true);
      tr.emitting = false;
      transform.position = Vector2.MoveTowards(transform.position, Target.position,speed*Time.deltaTime);//enemy position will move towards player using the speed it has.
    }

    public IEnumerator Return_To_Position()
    {

      speed = 1f;//enemy slows speed to return back to zero
      transform.position = Vector2.MoveTowards(transform.position, returnPos.position,speed*Time.deltaTime);//enemy position will move towards player using the speed it has.
      yield return new WaitForSeconds(1);
      states.Enemy_Behaviour = Enemy_Operator.Enemy.idle;
    }

    public IEnumerator Attack(float charge_Speed)
    {
      
      Attack(false);
      transform.position = Vector2.MoveTowards(transform.position, Target.position,speed*Time.deltaTime);//enemy will charge towards player times 2 of the speed.
      speed *= charge_Speed;//adds dash to enemy
      tr.emitting = true;
      yield return new WaitForSeconds(0.3f);
      tr.emitting = false;
       
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

public void Attack(bool Can_Attack)
{
    if(Can_Attack)
  {
    StartCoroutine(Attack(2f));
  }
  else
  {
    Moving(true);
  }
}


}
