using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurt_Detect : MonoBehaviour
{
   public Hearts_System health;
   bool can_be_hurt;
   void Start()
   {
     can_be_hurt = true;
   }
   private void OnTriggerEnter2D(Collider2D other)
   {
     if(can_be_hurt && other.tag == "Enemy")
     {
       StartCoroutine(IFrames());
     }
   }

   public IEnumerator IFrames()
   {
     health.TakeHeart(1);//takes one heart
     can_be_hurt = false;
     Debug.Log("Iframes on");
     yield return new WaitForSeconds(3);
     can_be_hurt = true;
     Debug.Log("Iframes off");

   }
}
