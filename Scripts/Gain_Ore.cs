using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gain_Ore : MonoBehaviour
{
   public Collectable collect;

   private void OnTriggerEnter2D(Collider2D other)
   {
      if(other.tag == "Player")
      {
          collect.collection();
            Destroy(gameObject);//destroys object after collision
      }
   }
}
