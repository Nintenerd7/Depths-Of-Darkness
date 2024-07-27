using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gain_Ore : MonoBehaviour
{
   private Collectable collect;

   private void Start()
   {
     collect.GetComponent<Collectable>();
   }
   private void OnTriggerEnter2D(Collider2D other)
   {
      if(other.tag == "Player")
      {
          collect.collection();
            Destroy(gameObject);//destroys object after collision
      }
   }
}
