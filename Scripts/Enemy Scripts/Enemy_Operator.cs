using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Operator : MonoBehaviour
{
    public Enemy Enemy_Behaviour;//allows class to access the Enum states
    public Enemy_Actions move;//gets the methods from other scripts 
    // Start is called before the first frame update
    void Start()
    {
        Enemy_Behaviour = Enemy.idle;//AI is idle on start
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        switch(Enemy_Behaviour)//Switch statement for enum state types 
        {
          case Enemy.idle://Idle state
          move.Idle();//call upon Idle method
          break;
          case Enemy.Chase://Chase State
          move.AIFollow();//call upon Follow method
          break;
          case Enemy.Attack:
          move.AIAttack();//call upon Attack method
          break;
        }
    }
    public enum Enemy
    {
        idle,//when  the enemy is idle
        Chase,//enemy starts following the players position
        Attack,//enemy charges toward the player
    }
}
