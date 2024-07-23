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
      returnPos = GameObject.FindGameObjectWithTag("EnemyPos").GetComponent<Transform>();
      Time.timeScale = 1f;
    }


 public IEnumerator StateMachine()
 {
      Moving(true, false);
      yield return new WaitForSeconds(2f);
      Moving(false, true);
      yield return new WaitForSeconds(1f);
      Moving(true, false);
      PD.IsAttacking = false;
 }
    //update
    public void Idle()
    {
      speed = 0f;
      Debug.Log("Idle");
    }

public void AIFollow()
{
    tr.emitting = false;
    speed = 1f;
    transform.position = Vector2.MoveTowards(transform.position, Target.position,speed*Time.deltaTime);//enemy position will move towards player using the speed it has.
}
public void AIAttack()
{
    tr.emitting = true;
    speed = 3f;
    transform.position = Vector2.MoveTowards(transform.position, Target.position,speed*Time.deltaTime);//enemy position will move towards player using the speed it has.
}
public void Moving(bool CanMove, bool CanAttack)
{

  switch(CanMove)
  {
    case true:
    states.Enemy_Behaviour = Enemy_Operator.Enemy.Chase;
    break;
    case false:
    states.Enemy_Behaviour = Enemy_Operator.Enemy.Attack;
    break;
  }
    switch(CanAttack)
  {
    case true:
    states.Enemy_Behaviour = Enemy_Operator.Enemy.Attack;
    break;
    case false:
    states.Enemy_Behaviour = Enemy_Operator.Enemy.Chase;
    break;
  }

}
}
