using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurt_Detect : MonoBehaviour
{
   public Hearts_System health;

   private void OnTriggerEnter2D(Collider2D other)
   {
     if(other.tag == "Enemy")
     {
       health.TakeHeart(1);//takes one heart
     }
   }
}
