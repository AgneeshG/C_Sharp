using System;
using System.Runtime.CompilerServices;

namespace BroCodeTwo
{
    internal class BroCodeTwo
    {
        public static void Main(string[] args)
        {
            //classTwo.clsTwoFuncone();

            //string value = classTwo.clsTwoFuncTwoReturntype(100);
            //Console.WriteLine(value);
            // ---------- class human 
            //Human human1 = new Human();
            //Human human2 = new Human();

            //human1.name = "Rick";
            //human1.age = 65;

            //human2.name = "Morty";
            //human2.age = 45;

            //human1.Eat();
            //human1.Sleep();

            //human2.Eat();
            //human2.Sleep();



            // --------- class car
            //carClass car1 = new carClass("Ford", "Mustang", 2022);
            //carClass car2 = new carClass("Honda", "City", 2023);

            //car1.details();

            //car Audi = new car("Audi", "Q5");
            //Console.WriteLine(Audi.wheels);
            //Audi.displayData();
            //car.go();

            

            Console.ReadKey();
        }
    }
    class Human 
    {
        public string name;
        public int age;

        public void Eat()
        {
            Console.WriteLine($"{name} is eating");
        }
        public void Sleep()
        {
            Console.WriteLine($"{name} is sleeping");
        }
        void run()
        {
            Console.WriteLine($"{name} is sleeping");
        }
    }

    class carClass : vehicle_inheritance
    {
        string name;
        string model;
        int year;

        public carClass(string name, string model, int year)
        {
            this.name = name;
            this.model = model;
            this.year = year;
        }
        public void details()
        {
            Console.WriteLine($"Car name : {name}, model : {model}, year : {year}");
        }
    }
}
