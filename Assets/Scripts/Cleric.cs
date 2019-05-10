using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Cleric : Class
    {
        

        public Cleric(string name) : base(name)
        {
           
        }

        public override string Area() {
            string area = "Cleric";
            //Debug.Log(name + " @ " + radius + " @ " + area);
            return area;
        }
    }
}
