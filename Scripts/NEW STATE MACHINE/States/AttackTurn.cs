using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.InfallibleCode.Enemy.AI
{
public class AttackTurn : State
{
        public AttackTurn(Enemy_Controller ai) : base(ai)
        {
        }
        public override IEnumerator attack()
        {
            ai.Attack_Player();//player Dashes
            ai.tr.emitting = true;
            yield return new WaitForSeconds(0.1f);
            ai.speed = 0;
            yield break;
        }


}
}
