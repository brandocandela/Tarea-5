using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Circle : Shape
    {
        public float radius;

        public Circle(string name, float radius) : base(name)
        {
            this.radius = radius;
        }

        public override string Area() {
            string area = "Cleric";
            //Debug.Log(name + " @ " + radius + " @ " + area);
            return area;
        }
    }
}
