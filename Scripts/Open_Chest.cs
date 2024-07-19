using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Open_Chest : MonoBehaviour
{
    public static bool hasKey = false;
    bool inrange;
public SpriteRenderer spriteRenderer;
public Sprite newSprite;
public GameObject Icon;
int KeyCount = 1;//how many keys the player has taken
    public KeyCode Unlock;

    private void Update()
    {
       if(inrange)
       {
         if (Input.GetKeyDown(Unlock))
        {
           spriteRenderer.sprite = newSprite; 
           hasKey = true;
           Debug.Log("Player has key");
           Icon.SetActive(true);
           KeyCount--;

        }
       if(KeyCount == 0)
       {
         Destroy(gameObject);
         Debug.Log("chest is gone");
       }
       }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.tag == "Player")
       {
         inrange = true;
         Debug.Log("Player is in range");
       }
    }
}
