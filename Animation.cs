using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite[] newSprite = new Sprite [8];
    public bool Swim;
    public Walking_States change;
    public GameObject Weapon;
    // Update is called once per frame
    private void Start()
    {
     Swim = false;
    }

    private void Update()
    {
      switch(Swim)
      {
       case true:
       Weapon.SetActive(false);
       change.behaviour = Walking_States.States.swim;
       break;
       case false:
       Weapon.SetActive(true);
       change.behaviour = Walking_States.States.walk;
       break;
      }

    }
    
    public void WalkInputs()
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

        public void WaterInputs()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
          spriteRenderer.sprite = newSprite[4]; 
        }
        if(Input.GetKeyDown(KeyCode.A))
        {
          spriteRenderer.sprite = newSprite[5];
        }
         if(Input.GetKeyDown(KeyCode.S))
        {
          spriteRenderer.sprite = newSprite[6];
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
           spriteRenderer.sprite = newSprite[7];
        }
    }
}
