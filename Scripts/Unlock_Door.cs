using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlock_Door : MonoBehaviour
{
   public static bool hasKey = false;
   bool inrange;
    public GameObject UnlockDoor;
    public KeyCode Unlock;

    private void Update()
    {
       if(inrange)
       {
         if (hasKey && Input.GetKeyDown(Unlock))
        {
          UnlockDoor.SetActive(false);

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
