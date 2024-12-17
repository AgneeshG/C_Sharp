using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    abstract public class Abstract_Shape
    {
        public int d1, d2;

        public Abstract_Shape(int d1, int d2)
        {
            this.d1 = d1;
            this.d2 = d2;
        }
        public Abstract_Shape()
        {
        }

        public override string ToString()
        {
            return $"D1 : {d1} \t D2 : {d2}";
        }
        abstract public int area();
    }
}
