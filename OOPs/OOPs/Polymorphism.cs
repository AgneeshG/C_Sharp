using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class Polymorphism
    {
        static int FuncZero=0;
        static int FuncOne = 0;
        static int FuncTwo = 0;
        static int FuncThree = 0;
        static int FuncFour = 0;
        public int id;
        public string name="";
        public int age;
        public string gender="";
        public Polymorphism(int id)
        {
            this.id = id;
            FuncOne++;
        }
        public Polymorphism(int id, string name)
        {
            this.id = id;
            this.name = name;
            FuncTwo++;
        }
        public Polymorphism(int id, string name, string gender)
        {
            this.id = id;
            this.name = name;
            this.gender = gender;
            FuncThree++;
        }
        public Polymorphism(int id, string name, int age, string gender)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.gender = gender;
            FuncFour++;
        }
        public Polymorphism()
        {
            FuncZero++;
        }

        public void ClassName()
        {
            Console.WriteLine("Polymorphisam class");
        }

        public override string ToString()
        {
            return "Pholymorphism Class";
        }
        static public void display()
        {
            Console.WriteLine($"FuncZero : {FuncZero} \t FuncOne : {FuncOne} \t FuncTwo : {FuncTwo} \t FuncThree : {FuncThree} \t FuncFour : {FuncFour}");
        }
    }
}
