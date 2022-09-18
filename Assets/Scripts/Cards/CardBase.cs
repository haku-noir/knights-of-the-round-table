using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cards
{
    [CreateAssetMenu]
    public class CardBase : ScriptableObject
    {
        [SerializeField] new string name;
        [SerializeField] Sprite image;
        [SerializeField][TextArea] string description;
        [SerializeField] int defaultAttackPoint;
        [SerializeField] CardType type;

        public string Name { get => name; set => name = value; }
        public Sprite Image { get => image; set => image = value; }
        public string Description { get => description; set => description = value; }
        public int DefaultAttackPoint { get => defaultAttackPoint; set => defaultAttackPoint = value; }
        public CardType CardType { get => type; }
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
        Galahad,
        Plomides,
        Percivale,
        Lancelot,
        Tristram,
        Arthur
    }
}