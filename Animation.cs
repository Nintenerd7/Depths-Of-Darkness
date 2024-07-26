using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite[] newSprite = new Sprite [4];
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
          spriteRenderer.sprite = newSprite[3]; 
        }
        if(Input.GetKeyDown(KeyCode.A))
        {
          spriteRenderer.sprite = newSprite[2];
        }
         if(Input.GetKeyDown(KeyCode.S))
        {
          spriteRenderer.sprite = newSprite[0];
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
           spriteRenderer.sprite = newSprite[1];
        }
    }
}
