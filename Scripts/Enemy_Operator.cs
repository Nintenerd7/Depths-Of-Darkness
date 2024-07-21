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
        Enemy_Behaviour = Enemy.patrol;
    }

    // Update is called once per frame
    void Update()
    {
        switch(Enemy_Behaviour)
        {
          case Enemy.patrol:
          move.Enemy_Patrol();
          //Access enemy patrol script
          break;
          case Enemy.Chase:
          move.Chase();
          //Access enemy Chase script
          break;
          case Enemy.Attack:
          //Access enemy attack script
          break;    

          case Enemy.Return:
          StartCoroutine(move.Return_To_Position());
          break;     
        }
    }

    public enum Enemy{
        patrol,
        Chase,
        Attack,
        Return,
    }
}
