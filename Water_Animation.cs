using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water_Animation : MonoBehaviour
{
    public Animation anim;
    private void OnTriggerEnter2D(Collider2D other)
    {
      if(other.tag == "Player")
      {
        anim.Swim = true;
      }

    }
void OnTriggerExit2D(Collider2D other)
    {
      anim.Swim = false;
    }

}
