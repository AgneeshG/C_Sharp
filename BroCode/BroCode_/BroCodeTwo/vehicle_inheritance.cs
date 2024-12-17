using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace BroCodeTwo
{
    public class vehicle_inheritance
    {
        public int initialSpeed = 0;

        public static void go()
        {
            Console.WriteLine("This vehicle is moving!");
        }

        car carOne = new car("Honda", "City");
        
    }

    public class car : vehicle_inheritance
    {
        public int maxSpeed = 180;
        public int wheels = 4;
        string name;
        string model;
        public car(string name, string model) {
            this.name = name;
            this.model = model;
        }

        public void displayData()
        {

            Console.WriteLine($"Car name : {name} and car model : {model}");
        }
        
        
    }

    public class bike : vehicle_inheritance
    {
        public int maxSpeed = 130;
        public int wheels = 2;
    }

    public class boat : vehicle_inheritance
    {
        public int maxSpeed = 120;
        public int wheels = 0;
    }
}
