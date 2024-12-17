using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class PolymorphismOne : Polymorphism, InterfaceOne
    {
        public PolymorphismOne(int id, string name, int age, string gender) : base(id, name, age, gender)
        {

        }
        public PolymorphismOne() : base()
        {

        }

        public new void ClassName()
        {
            Console.WriteLine("Class Polymorphism One");
        }

        public override string ToString()
        {
            return base.ToString() + "One";
        }
    }
}
