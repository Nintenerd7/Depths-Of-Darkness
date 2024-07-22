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
    //

    void Start()
    {
      Target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    //update
    public void Idle()
    {
      Debug.Log("Idle");
    }

    public void Chase()
    {
      speed = 1f;//enemy kicks up speed 
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
      transform.position = Vector2.MoveTowards(transform.position, Target.position,speed*Time.deltaTime);//enemy will charge towards player times 2 of the speed.
      speed *= charge_Speed;//adds dash to enemy
      tr.emitting = true;
      yield return new WaitForSeconds(0.1f);
      tr.emitting = false;
    }



}
