using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Count_Text : MonoBehaviour
{
   [SerializeField]public TMP_Text CountText;
  public void collection(int total)
    {
        Collectable.Count += total;
        CountText.text = Collectable.Count.ToString("0");
    }
}
