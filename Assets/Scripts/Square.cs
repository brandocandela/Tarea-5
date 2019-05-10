using System;
using System.Collections.Generic;
using System.Linq;

using UnityEngine;

namespace Shapes
{
    class Square : Shape
    {
        public float side;

        public Square(string name, float side) : base(name)
        {
            this.side = side;
        }

        public override string Area()
        {
            string area = "Knight";
            //Debug.Log(name + " @ " + side + " @ " + area);
            return area;
        }
    }
}
