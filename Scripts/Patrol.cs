using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    //variables
    public float speed;
    public Hearts_System attack;
    public Enemy_Operator states;
    public Transform Target;
    public Transform returnPos;
    //

    void Start()
    {
      Target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    //update
    public void Idle()
    {
      speed = 0;//enemy stands still
    }

    public void Chase()
    {
      speed = 1.5f;//enemy kicks up speed 
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
      transform.position = Vector2.MoveTowards(transform.position, Target.position,speed*Time.deltaTime);
      speed += charge_Speed;//adds dash to enemy
      attack.TakeHeart(1);//takes heart from the player
      yield return new WaitForSeconds(0.01f);
      states.Enemy_Behaviour = Enemy_Operator.Enemy.Return;
   
    }
}
