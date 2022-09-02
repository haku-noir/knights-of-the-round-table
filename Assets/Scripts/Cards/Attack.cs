using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Params;

namespace Cards
{
    public class Attack : IPoint
    {
        public int Point { get; set; }

        public Attack() : this(0)
        { }

        public Attack(int point)
        {
            Point = point;
        }

        public void AddPoint(int point)
        {
            Point += point;
        }

        public void SubtractPoint(int point)
        {
            Point -= point;
        }
    }
}