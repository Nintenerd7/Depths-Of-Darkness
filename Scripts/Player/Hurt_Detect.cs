using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurt_Detect : MonoBehaviour
{
   public Hearts_System health;
   bool can_be_hurt;
       public SpriteRenderer sprite;
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
     else if(other.tag == "Health")
     {
      health.GiveHeart();
     }
     if(health.HeartHealth == 0)
     {
       StopAllCoroutines();
     }
   }

   public IEnumerator IFrames()
   {
     health.TakeHeart(1);//takes one heart
     can_be_hurt = false;
     Debug.Log("Iframes on");
     sprite.color = new Color (0, 0, 0, 0);
     yield return new WaitForSeconds(0.2f);
     sprite.color = new Color (1, 1, 1, 1);
     yield return new WaitForSeconds(0.2f);
     sprite.color = new Color (0, 0, 0, 0);
     yield return new WaitForSeconds(0.2f);
     sprite.color = new Color (1, 1, 1, 1);
     yield return new WaitForSeconds(2f);
     can_be_hurt = true;
     Debug.Log("Iframes off");
   }
}
