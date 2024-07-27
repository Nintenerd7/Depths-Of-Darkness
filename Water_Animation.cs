using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water_Animation : MonoBehaviour
{
    public Top_Down_movement swim;
      void OnTriggerEnter2D(Collider2D col)
    {
       if(col.tag == "Player")
       {
         swim.UpdateWater();
       } 
    }
        void OnTriggerExit2D(Collider2D other)
    {
        swim.Swimming = false;
    }

}
