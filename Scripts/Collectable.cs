using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Collectable : MonoBehaviour
{
  public static int Count = 0;
    [SerializeField]public TMP_Text CountText;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            //AudioSourceController.Instance.PlaySFX("Collect");
            collection(1);
            Destroy(gameObject);
        }

    }

 public void collection(int total)
    {
        Count += total;
        CountText.text = Count.ToString("0");
    }
}