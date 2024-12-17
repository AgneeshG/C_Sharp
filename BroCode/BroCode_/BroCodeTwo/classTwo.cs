using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BroCodeTwo
{
    public class classTwo
    {
        public static string name = "Class Two";
        public static int age = 2;

        public static void clsTwoFuncone()
        {
            Console.WriteLine("This is first sample function in classTwo class.");
        }

        public static string clsTwoFuncTwoReturntype(int number)
        {
            string name = "Class Two Function Two";
            string value = name + number;
            Console.WriteLine("This is second sample functin in classTwo class with return type.");
            return value;
        }
    }
}
