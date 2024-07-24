using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loot_Types : MonoBehaviour
{
  public static bool Can_loot;
  public GameObject heart;
 public bool CanSpawn = false;
  private void Start()
  {
   CanSpawn = false;
  }
  private void Update()
  {
    switch(Can_loot)
    {
     case true:
     CanSpawn = true;
     StartCoroutine(Loot_Randomizer());
     break;
     case false:
     Debug.Log("No loot");
     break;
    }
  }
//randomizes what loot you will recieve
  public IEnumerator Loot_Randomizer()
  {
       if (Random.Range(0, 6) <= 3)//if random range is more or equal to two
            {
              CanSpawn = false;
               Debug.Log("No loot");
            }
            else if (Random.Range(0, 6) >= 4||Random.Range(0, 6) == 6)//if random range is equal to six
            {
                Heart();
                yield return new WaitForSeconds(0.4f);
                
            }
  }


    public void Heart()
  {
    if(CanSpawn)
    {
    Instantiate(heart,transform.position, Quaternion.identity);//spawns loot from enemy position
    CanSpawn = false;
    }
  }
}
