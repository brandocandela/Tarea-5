using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Warrior : Class
    {


        public Warrior(string name) : base(name)
        {

        }

        public override string Area()
        {
            string area = "Warrior";
            //Debug.Log(name + " @ " + radius + " @ " + area);
            return area;
        }
    }
}