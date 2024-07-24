using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loot_Types : MonoBehaviour
{
  public GameObject heart;
  public int Count = 0;
  bool Can_Heal;

  void Start()
  {
         Can_Heal = false;
  }
  private void Update()
  {
    if(!Can_Heal)
    {
      Can_Heal = true;
      StartCoroutine(Heart());
    }
  }
//randomizes what loot you will recieve


    public IEnumerator Heart()
  {
    Count ++;
    if(Count >=1)
    {
      Count = 1;
      Instantiate(heart,transform.position, Quaternion.identity);//spawns loot from enemy position
      Can_Heal = false;
    }
    yield break;
  }
}
