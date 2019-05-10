using System;
using System.Collections.Generic;
using System.Linq;

using UnityEngine;

namespace Shapes
{
    class Knight : Class
    {
       

        public Knight(string name) : base(name)
        {
           
        }

        public override string Area()
        {
            string area = "Knight";
            //Debug.Log(name + " @ " + side + " @ " + area);
            return area;
        }
    }
}
