using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Params;

namespace Cards
{
    public class Attack : IPoint
    {
        public int Point { get; set; }
        public int DefaultPoint { get; }

        [SerializeField] private static int defaultAttackPoint = 0;

        public Attack() : this(defaultAttackPoint)
        { }

        public Attack(int defaultPoint)
        {
            Point = defaultPoint;
            DefaultPoint = defaultPoint;
        }

        public void AddPoint(int point)
        {
            Point += point;
        }

        public void MulPoint(int num)
        {
            Point *= num;
        }
    }
}