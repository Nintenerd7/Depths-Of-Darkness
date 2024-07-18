using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tourches : MonoBehaviour
{
  public GameObject Fire;

  private void OnTriggerEnter2D(Collider2D other)
  {
     if(other.tag == "Fire")
     {
        Fire.SetActive(true);
     }
  }
}
