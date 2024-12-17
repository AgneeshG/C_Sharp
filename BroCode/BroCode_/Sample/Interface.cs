using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    internal class Interface
    {
        public static void MainFunc()
        {
            Rabbit whiteRabbit = new Rabbit();
            Hawk hawk = new Hawk();
            Fish fish = new Fish();

            whiteRabbit.flee();
            hawk.hunt();
            fish.flee();
            fish.hunt();


            Console.ReadKey();

        }

        interface Prey
        {
            void flee();
        }
        interface predator
        {
            void hunt();
        }

        class Rabbit : Prey
        {
            public void flee()
            {
                Console.WriteLine("Rabbit runs away");
            }
        }
        class Hawk : predator
        {
            public void hunt()
            {
                Console.WriteLine("The Hawk is searching for food");
            }
        }
        class Fish : Prey, predator
        {
            public void flee()
            {
                Console.WriteLine("The fish swims away");
            }
            public void hunt()
            {
                Console.WriteLine("The fish is searching for samll fish");
            }
        }
    }
}
