using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Params
{
    interface IPoint
    {
        int Point { get; set; }
        int DefaultPoint { get; }

        void AddPoint(int point);
        void MulPoint(int point);
    }
}