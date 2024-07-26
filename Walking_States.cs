using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking_States : MonoBehaviour
{
    public States behaviour;
    public Animation state;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         switch(behaviour)
         {
          case States.walk:
          state.WalkInputs();
          break;
          case States.swim:
          state.WaterInputs();
          break;
         }
    }

   public enum States
    {
      walk,
      swim,
    }
}
