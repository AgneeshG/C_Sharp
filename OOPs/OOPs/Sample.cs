using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class Sample : MarkDetails
    {
        public int SamValue;
        public Sample(int rollNum, string name, int age, int marks, int percentage, int SamValue): base(rollNum, name, age, marks, percentage)
        {
            this.SamValue = SamValue;
        }
        public Sample(): base()
        {

        }
    }
}
