using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class RectangleOne : Abstract_Shape
    {
        public RectangleOne(int d1, int d2) : base(d1, d2)
        {

        }
        public override int area()
        {
            return d1 * d2;
        }

        public void printString()
        {
            Console.Write("Hello");
        }
    }
}
