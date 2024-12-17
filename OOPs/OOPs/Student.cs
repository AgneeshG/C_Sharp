//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace OOPs
{
    public class Student
    {
        public int rollNum { get; set; }
        public string name { get; set; }
        public int age { get; set; }


        public Student(int rollNum ,string name, int age)
        {
            this.rollNum = rollNum;
            this.name = name;
            this.age = age;
        }

        public Student()
        {

        }

        public virtual void SetData()
        {
            Console.Write("Enter your roll number : ");
            rollNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your name : ");
            name = Console.ReadLine();
            Console.Write("Enter your age : ");
            age = Convert.ToInt32(Console.ReadLine());
        }

        public virtual void GetData()
        {
            Console.WriteLine("Roll number : " + rollNum);
            Console.WriteLine("Name :        " + name);
            Console.WriteLine("Age :         " + age);
        }

        public void GetName()
        {
            Console.WriteLine("Student Name : " +name);
        }
        public override string ToString()
        {
            return "";
        }
        
    }


}
    