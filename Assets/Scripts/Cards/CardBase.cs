using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cards
{
    public class CardBase : ScriptableObject
    {
        [SerializeField] CardInfo info;
        [SerializeField] CardType type;
        [SerializeField] Attack attack;
    }

    public enum CardType
    {
        Mordred,
        Gareth,
        Gaheris,
        Agravain,
        Gawain,
        Bedivere,
        Kay,
        Percivale,
        Galahad,
        Lancelot,
        Tristram,
        Arthur
    }
}