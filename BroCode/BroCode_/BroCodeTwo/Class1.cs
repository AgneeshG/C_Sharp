using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BroCodeTwo
{
    class Class1
    {

        public static void mainFunc()
        {
            
        }
    }

    abstract class vehicle
    {
        public void vehiclefunc()
        {

        }
        public void vehicleinfo(int wheels, string color)
        {
            Console.WriteLine($"Vehicle number of wheels : {wheels} and color is : {color}");
        }
    }
    class Bike : vehicle
    {
        int wheels = 2;
        string color;

        public Bike(string color)
        {
            this.color = color;
        }
        public void display()
        {
            Console.WriteLine($"Bike color : {this.color}");
        }
    }
    class Car : vehicle
    {
        int wheels = 4;
        string color;

        public Car(string color)
        {
            this.color = color;
        }
        public void display()
        {
            Console.WriteLine($"Car color : {this.color}");
        }

    }

}
