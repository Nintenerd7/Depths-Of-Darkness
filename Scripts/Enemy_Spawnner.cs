using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawnner : MonoBehaviour
{
  public GameObject[] Enemy = new GameObject[2];
  public GameObject[] Doors = new GameObject[2];
  public static int count;
  public static bool CanOpen;
  
  private void Update()
  {
        if(count == 2)
        {
        CanOpen = true;
        }
  }
  private void OnTriggerEnter2D(Collider2D other)
  {
     if(other.tag == "Fire")
     {
        Doors[0].SetActive(true);//blocks player from escaping
        Enemy[0].SetActive(true);
        Enemy[1].SetActive(true);
     }
     if(CanOpen)
     {
      AudioSourceController.Instance.PlaySFX("Correct");
        Doors[0].SetActive(false);
        Doors[1].SetActive(false);
        Destroy(gameObject);
     }
  }
}
