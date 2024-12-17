using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace BroCodeTwo
{
    class Class1
    {

        public static void Main()
        {
            car audi = new car(150);
            audi.Speed = 300;
            Console.WriteLine(audi.Speed);

            Console.ReadKey();
        }


    }

    class car
    {
        private int speed;

        public car(int speed)
        {
            Speed = speed;
        }
        public int Speed
        {
            get { return speed; }
            set
            {
                if (value > 250)
                {
                    speed = 250;
                }
                else
                {
                    speed = value;
                }
            }
        }
    }
    

}
