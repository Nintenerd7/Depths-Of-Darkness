using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace com.InfallibleCode.Enemy.AI
{
public class Idle : State
{
        public Idle(Enemy_Controller ai) : base(ai)
        {
        }
        public override IEnumerator Start()
        {
             if(ai.Is_In_Sight)
     {
       ai.SetState(new Chase(ai));
      
     }
     else
     {
        ai.Idle();
        yield break;
        }

}
}
}
