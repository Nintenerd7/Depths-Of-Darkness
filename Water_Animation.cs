using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water_Animation : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite newSwimSprite;

    private void OnTriggerEnter2D(Collider2D other)
    {
      if(other.tag == "Player")
      {
       spriteRenderer.sprite = newSwimSprite; 
      }
    }
}
