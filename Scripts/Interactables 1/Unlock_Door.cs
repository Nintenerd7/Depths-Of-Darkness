using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlock_Door : MonoBehaviour
{
   bool inrange = false;
    public GameObject UnlockDoor;
    public GameObject Indicator;
    public KeyCode Unlock;
    public Open_Chest toggle;
    private void Update()
    {
       if(inrange)
       {
         if (Input.GetKeyDown(Unlock))
        {
          UnlockDoor.SetActive(false);
          Indicator.SetActive(false);
          toggle.Icon[0].SetActive(false);
          AudioSourceController.Instance.PlaySFX("Correct");
        }
       }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(Open_Chest.hasKey && collision.tag == "Player")
       {
        Indicator.SetActive(true);
         inrange = true;
         Open_Chest.hasKey = false;//player no longer has key
         Debug.Log("Player is in range");
       }
        
    }
}
