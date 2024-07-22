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
    void Update()
    {
        switch(Enemy_Behaviour)
        {
          case Enemy.idle:
          move.Idle();
          break;
          case Enemy.Chase:
          StartCoroutine(move.Chase());
          //Access enemy Chase script
          break;
          case Enemy.Attack:
          StartCoroutine(move.Attack(2f));
          break;    

          case Enemy.Return:
          StartCoroutine(move.Return_To_Position());
          break;     
        }
    }

    public enum Enemy{
        idle,//when  the enemy is idle
        Chase,//enemy starts following the players position
        Attack,//funny damage
        Return,//return to position and will change to idle state. 
    }
}
