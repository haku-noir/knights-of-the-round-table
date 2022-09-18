using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cards {
    public class CardManager : MonoBehaviour
    {
        [SerializeField] CardBase[] cardBases;
        [SerializeField] Card cardPrefab;

        // Start is called before the first frame update
        void Start()
        {
            foreach (var e in cardBases)
            {
                GenerateCard(e);
            }
        }

        void GenerateCard(CardBase cardBase)
        {
            Card card = Instantiate(cardPrefab);
            CardState cardState = new CardState(cardBase);
            card.Init(cardState);
        }
    }
}