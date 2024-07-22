using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Detection : MonoBehaviour
{
    public Patrol condition;
   private void OnTriggerEnter2D(Collider2D other)
   {
     if(other.tag == "Player")
     {
      condition.CanMove = true;
       condition.Follow_Condition();
     }
   }

}
