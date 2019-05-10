using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Class
    {
        protected string name;
        public string Name {
            get {
                return name;
            }
        }

        public Class(string name) {
            this.name = name;
        }


        public virtual string Area() {
            return null;
        }
    }
}
