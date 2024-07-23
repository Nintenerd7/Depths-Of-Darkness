using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace com.InfallibleCode.Enemy.AI
{
    public abstract class StateMachine:MonoBehaviour
    {
        protected State States;
        public void SetState(State state)
        {
            States = state;
            StartCoroutine(States.Start());
            StartCoroutine(States.chase());
            StartCoroutine(States.attack());
        }
    }
}
