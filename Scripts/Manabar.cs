using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Manabar : MonoBehaviour
{
      public static RectTransform bar;
        public float totalMana  = 6.3875f;
        void Start()
        {
            bar = GetComponent<RectTransform>();
            SetSize(totalMana);
        }
        public void Magic_Cost(float Magic)
        {
            if ((totalMana -= Magic) >= 0f)
            {
                totalMana -= Magic;
            }
            else if (totalMana <= 0)
            {
             totalMana = 0;
            }
            SetSize(totalMana);
        }
        public void Magic_Gain(float Magic)
        {
            if ((totalMana += Magic) <= 0f)
            {
                totalMana += Magic;
            }
            else if (totalMana >= 1)
            {
             totalMana = 1;
            }
            SetSize(totalMana);
        }
        public static void SetSize(float size)
        {
            bar.localScale = new Vector3(size, 0.22f);
        }
}
