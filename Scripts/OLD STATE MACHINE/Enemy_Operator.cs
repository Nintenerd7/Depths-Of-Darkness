using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Operator : MonoBehaviour
{
    public Enemy Enemy_Behaviour;
    public Patrol move;
    //object orientation patrol
    // Start is called before the first frame update
    void Start()
    {
        Enemy_Behaviour = Enemy.idle;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        switch(Enemy_Behaviour)
        {
          case Enemy.idle:
          move.Idle();
          break;
          case Enemy.Chase:
          move.Chase();
          //Access enemy Chase script
          break;
          case Enemy.Return:
          StartCoroutine(move.Return_To_Position());
          break;     
        }
        LayerMask mask = LayerMask.GetMask("Collision");
            if (Physics.Raycast(transform.position, transform.forward, 20.0f, mask))
            {
                Debug.Log("Enemy Hit a colision");
            }

    }

    public enum Enemy{
        idle,//when  the enemy is idle
        Chase,//enemy starts following the players position
        Return,//return to position and will change to idle state. 
    }
}
