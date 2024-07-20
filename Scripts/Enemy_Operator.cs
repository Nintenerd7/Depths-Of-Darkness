using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Operator : MonoBehaviour
{
    public Enemy Enemy_Behaviour;
    //object orientation patrol
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch(Enemy_Behaviour)
        {
          case Enemy.patrol:
          //Access enemy patrol script
          break;
          case Enemy.Chase:
          //Access enemy Chase script
          break;
          case Enemy.Attack:
          //Access enemy attack script
          break;        
        }
    }

    public enum Enemy{
        patrol,
        Chase,
        Attack,
    }
}
