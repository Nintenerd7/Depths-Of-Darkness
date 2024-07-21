using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurt_Detect : MonoBehaviour
{
   public Enemy_Operator enemyAttack;

   private void OnTriggerEnter2D(Collider2D other)
   {
     if(other.tag == "Enemy")
     {
       enemyAttack.Enemy_Behaviour = Enemy_Operator.Enemy.Attack;
     }
   }
}
