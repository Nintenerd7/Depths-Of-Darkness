using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Detection : MonoBehaviour
{
    public Enemy_Operator enemyFollow;
   private void OnTriggerEnter2D(Collider2D other)
   {
     if(other.tag == "Player")
     {
       enemyFollow.Enemy_Behaviour = Enemy_Operator.Enemy.Chase;
     }
   }
}
