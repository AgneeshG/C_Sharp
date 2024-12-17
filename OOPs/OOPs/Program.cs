//using System;
//using System.Collections.Generic;

namespace OOPs
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Arun = new Student(05, "Arun Kumar", 34);
            MarkDetails stdone = new MarkDetails(04, "Arun", 24, 421, 82);
            //stdone.SetData();
            //stdone.GetData();
            //stdone.GetName();
            //Arun.GetData();
            //Console.WriteLine(stdone);


            Abstract_Shape ShapeOne = new RectangleOne(12, 32);
            Console.WriteLine(ShapeOne.area());
            Console.WriteLine(ShapeOne);

            Polymorphism one = new Polymorphism();
            Polymorphism oneOne = new Polymorphism();
            Polymorphism oneTwo = new Polymorphism();
            Polymorphism two = new Polymorphism(02);
            Polymorphism three = new Polymorphism(03,"Manju");
            Polymorphism.display();
            Polymorphism four = new PolymorphismOne();
            four.ClassName();
            




            Console.ReadKey();       
        }
    }
}
