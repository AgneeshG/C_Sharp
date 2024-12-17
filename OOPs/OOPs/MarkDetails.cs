//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace OOPs
{
    internal class MarkDetails : Student
    {
        public int marks;
        public int percentage;

        public MarkDetails(int rollNum, string name, int age, int marks, int percentage) : base(rollNum, name, age)
        {
            this.marks = marks;
            this.percentage = percentage;
        }
        public MarkDetails() : base()
        {

        }

        public override void GetData()
        {
            base.GetData();
            Console.WriteLine("Total marks : " + marks);
            Console.WriteLine("Percentage : " + percentage);
        }
        public override void SetData()
        {
            base.SetData();
            Console.Write("Enter total mark : ");
            marks = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your persentage : ");
            percentage = Convert.ToInt32(Console.ReadLine());

        }
        public override string ToString()
        {
            return $"Roll number : {rollNum} \t Name : {name} \t Age : {age} \t Total marks : {marks} \t Percentage : {percentage}";
        }
    }
}
