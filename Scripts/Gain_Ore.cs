using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gain_Ore : MonoBehaviour
{

   private void OnTriggerEnter2D(Collider2D other)
   {
      if(other.tag == "Player")
      {
          Collectable.Count ++;
            Destroy(gameObject);//destroys object after collision
      }
   }
}
