using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cards
{
    [CreateAssetMenu]
    public class CardBase : ScriptableObject
    {
        [SerializeField] new string name;
        [SerializeField] Sprite icon;
        [SerializeField][TextArea] string description;
        [SerializeField] int defaultAttackPoint;
        [SerializeField] CardType type;

        public string Name { get => name; set => name = value; }
        public Sprite Icon { get => icon; set => icon = value; }
        public string Description { get => description; set => description = value; }
        public int DefaultAttackPoint { get => defaultAttackPoint; set => defaultAttackPoint = value; }
        public CardType Type { get => type; }
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