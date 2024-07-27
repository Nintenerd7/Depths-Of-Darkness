using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Collectable : MonoBehaviour
{
  public static int Count = 0;
   [SerializeField]public TMP_Text CountText;
     public Manabar Mana;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
          AudioSourceController.Instance.PlaySFX("Collect");
           collection();
            Destroy(gameObject);
            Mana.Magic_Gain(0.05f);
        }

    }
      public void collection()
    {
        Count ++;
        CountText.text = Count.ToString("0");
    }
}