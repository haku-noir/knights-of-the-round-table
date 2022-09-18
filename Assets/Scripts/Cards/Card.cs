using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Cards
{
    public class Card : MonoBehaviour
    {
        [SerializeField] Image image;
        //[SerializeField] TextMeshProUGUI nameText;
        [SerializeField] TextMeshProUGUI descriptionText;
        [SerializeField] TextMeshProUGUI attackText;

        private CardState state;

        public void Init(CardState state)
        {
            this.state = state;
            Draw();
        }

        public void Draw()
        {
            var cardBase = this.state.CardBase;
            this.image.sprite = cardBase.Image;
            //this.nameText.SetText(cardBase.Name);
            this.descriptionText.SetText(cardBase.Description);
            this.attackText.SetText(this.state.Attack.Point.ToString());
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}