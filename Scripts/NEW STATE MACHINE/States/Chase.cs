using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace com.InfallibleCode.Enemy.AI
{
public class Chase : State
{
        public Chase(Enemy_Controller ai) : base(ai)
        {
        }
        public override IEnumerator chase()
        {
            ai.tr.emitting = false;
            ai.Chase_player();
            yield return new WaitForSeconds(5f);
            ai.SetState(new AttackTurn(ai));
            yield break;
        }

}
}
