using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cards
{
    public class CardState
    {
        public CardBase CardBase { get; }
        public Attack Attack { get; }

        public CardState(CardBase cardBase)
        {
            CardBase = cardBase;
            Attack = new Attack(CardBase.DefaultAttackPoint);
        }

        public void ResetState()
        {
            Attack.Point = CardBase.DefaultAttackPoint;
        }
    }
}