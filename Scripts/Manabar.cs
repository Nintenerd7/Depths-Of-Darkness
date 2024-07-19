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
        public void Damage(float Magic)
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

        public static void SetSize(float size)
        {
            bar.localScale = new Vector3(size, 0.7265625f);
        }
}
