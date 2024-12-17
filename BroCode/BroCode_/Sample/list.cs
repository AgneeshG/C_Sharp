using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    internal class list
    {
        public static void ListFunc()
        {
            string[] Animals = { "Lion", "Tiger", "Cheeta", "Bear" };

            string[] Fruits = new string[4];
            Fruits[0] = "Papaya";
            Fruits[1] = "Banana";
            Fruits[2] = "Mango";
            Fruits[3] = "Orange";
            //Fruits[4] = "Lemon";

            Console.WriteLine("Animals : ");
            foreach (string animal in Animals)
            {
                Console.WriteLine(animal);
            }
            Console.WriteLine();

            Console.WriteLine("Fruits : ");
            foreach (string fruit in Fruits)
            {
                Console.WriteLine(fruit);
            }
            Console.WriteLine();


            Console.WriteLine("---- List -----");
            List<string> food = new List<string>();
            food.Add("Pizza");
            food.Add("hotdog");
            food.Add("fries");
            food.Add("hamburger");
            food.Remove("fries");
            food.Insert(2, "sushi");
            Console.WriteLine(food.Count);
            Console.WriteLine(food.IndexOf("hamburger"));
            Console.WriteLine("contains : " + food.Contains("sushi"));

            foreach (string item in food)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("----- List of Objects -----");

            List<Players> team = new List<Players>();

            Players player1 = new Players("Chad");
            Players player2 = new Players("Steve");
            Players player3 = new Players("Karen");

            team.Add(player1);
            team.Add(player2);
            team.Add(player3);

            foreach (Players player in team)
            {
                Console.WriteLine(player);
            }


            Console.ReadKey();
        }
    }
    class Players
    {
        public string name;

        public Players(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
