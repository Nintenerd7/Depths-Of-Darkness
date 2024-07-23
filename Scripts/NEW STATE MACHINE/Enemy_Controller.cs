using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.InfallibleCode.Enemy.AI
{
public class Enemy_Controller : StateMachine
{
    public float speed = 1f;
    public bool Is_In_Sight = false;
    public TrailRenderer tr;
    public Transform Target;
    public Transform Return;

private void Update()
{
       SetState(new Idle(this));
      RaycastHit2D ray = Physics2D.Raycast(transform.position, Target.position - transform.position);

     if(ray.collider != null)
     {
      Is_In_Sight = ray.collider.CompareTag("Player");
      if(Is_In_Sight)
      {
        Debug.DrawRay(transform.position, Target.position - transform.position, Color.green);
      }
      else
      {
        Debug.DrawRay(transform.position, Target.position - transform.position, Color.red);
      }
     }
}

    public void Attack_Player()
    {
      speed = 2f;//adds dash to enemy
      if(speed >= 2f)
     {
       speed = 2f;
     }
    }
    public void Chase_player()
    {
     speed = 1f;
     if(speed >= 1f)
     {
       speed = 1f;
     }
     transform.position = Vector2.MoveTowards(transform.position, Target.position,speed*Time.unscaledDeltaTime);//enemy will charge towards player times 2 of the speed.
    }
    public void Idle()
    {
     if(speed >= 0f)
     {
       speed = 0f;
     }
    }

    public void Cooldown()
    {
       speed = 0f;
       transform.position = Vector2.MoveTowards(transform.position, Return.position,speed*Time.unscaledDeltaTime);
    }

}
}
