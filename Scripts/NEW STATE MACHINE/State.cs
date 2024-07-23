using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace com.InfallibleCode.Enemy.AI
{
public abstract class State 
{
    protected readonly Enemy_Controller ai;
    public State(Enemy_Controller System)
    {
      ai = System;
    }
      public virtual IEnumerator Start()
        {
            yield break;
        }
        public virtual IEnumerator attack()
        {
            yield break;
        }
    
         public virtual IEnumerator chase()
        {
            yield break;
        }
}
}
