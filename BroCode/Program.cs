using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BroCode
{
    internal class variables_typecasting
    {
        static void Main(string[] args)
        {
            //Console.Write("sample text 'write' ");
            //Console.WriteLine("sample text 'writeline'");

            //string val = Console.ReadLine();
            //Console.WriteLine(val);

            int number1 = 10;
            float number2 = 23.4f;
            double number3 = 34.2523;
            string value1 = "sample text";
            char charVal = '@';

            const string str = "constant value";


            // --------- type casting ------------
            //double num = 54.56;
            //int _num = Convert.ToInt32(num);
            //Console.WriteLine($"converting string to number using Convert.ToInt32() method : {_num.GetType()}");

            //int num1 = 235;
            //double _num1 = Convert.ToDouble(num1);

            //int num2 = 34;
            //string _num2 = Convert.ToString(num2);

            //string a = "$";
            //char _a = Convert.ToChar(a);

            //string b = "true";
            //bool _b = Convert.ToBoolean(b);

            //Console.WriteLine("Enter your age");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Your age is : {age}");

            //Console.WriteLine($"{ _num1}, {_num1.GetType()}");
            //Console.WriteLine($"{_num2}, {_num2.GetType()}");
            //Console.WriteLine($"{_a}, {_a.GetType()}");
            //Console.WriteLine($"{_b}, {_b.GetType()}");


            // ------- Math functions -------

            //Console.WriteLine("------- Math functions --------");

            //double x = 5;
            //double y = 4.32;
            //double z = -6;
            //double A = Math.Pow(x, 3);
            //double B = Math.Sqrt(x);
            //double C = Math.Abs(z);
            //double D = Math.Round(y);
            //double E = Math.Ceiling(y);

            //Console.WriteLine($"math.pow(5,3) : {A}");
            //Console.WriteLine($"math.Sqrt(5) : {B}");
            //Console.WriteLine($"math.Abs(-6) : {C}");
            //Console.WriteLine($"math.Round(4.32) : {D}");
            //Console.WriteLine($"math.Ceiling(4.32) : {E}");


            // ------- String methods --------

            //Console.WriteLine("------- String methods -------");

            //string userName = "Test User";
            //string name0 = userName.ToUpper();
            //string name1 = userName.ToLower();
            //string name2 = userName.Replace(" ", "_");
            //string name3 = userName.Insert(0, "Mr. ");
            //string name4 = userName.Substring(5, 4);
            //Console.WriteLine($"{name0}, {name1}, {name2}, {name3}, {name4}");


            // ------- Decision making -------

            //Console.WriteLine("------- Decision making --------");



            // ----------- Loop -----------
            //Console.WriteLine("------- Loop --------");

            //Console.WriteLine("Enter your name");
            //string name = Console.ReadLine();
            //while(name == "")
            //{
            //    Console.WriteLine("Enter your name");
            //    name = Console.ReadLine();
            //}
            //Console.WriteLine("Hello " + name);


            // ----------- Number Guessing Game -----------
            //Console.WriteLine(" --------- Number Guessing Game --------- ");


            //Random random = new Random();
            //bool playAgain = true;
            //int min = 1;
            //int max = 100;
            //int guess;
            //int number;
            //int guesses;
            //string response;

            //while(playAgain == true)
            //{
            //    guess = 0;
            //    guesses = 0;
            //    response = "";
            //    number = random.Next(min, max + 1);

            //    while(guess != number)
            //    {
            //        Console.WriteLine("Guess a number between " + min + " - " + max + ": ");
            //        guess = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("Guess : " + guess);
            //        if(guess > number){
            //            Console.WriteLine(guess + "is to high");
            //        } 
            //        else if(guess < number)
            //        {
            //            Console.WriteLine(guess + "is to low!");
            //        }
            //        guesses++;
            //    }
            //    Console.WriteLine("Number : " + number);
            //    Console.WriteLine("YOU WIN!!");
            //    Console.WriteLine("Guesses : " + guesses);

            //    Console.WriteLine("Would you like to play again (Y/N) :");
            //    response = Console.ReadLine().ToUpper();

            //    if(response == "Y")
            //    {
            //        playAgain = true;
            //    }
            //    else
            //    {
            //        playAgain = false;
            //    }
            //}

            //Console.WriteLine("Thanks for playing!... I Guess");


            // ---------- Rock, Paper, Scissors game --------

            //Random random = new Random();
            //bool playagain = true;
            //string player;
            //string computer;

            //while (playagain)
            //{
            //    player = "";
            //    computer = "";

            //    while(player != "ROCK" && player != "PAPER" && player != "SCISSORS")
            //    {
            //        Console.WriteLine("Enter ROCK, PAPER or SCISSORS");
            //        player = Console.ReadLine();
            //        player = player.ToUpper();
            //    }

            //    switch (random.Next(1, 4))
            //    {
            //        case 1:
            //            computer = "ROCK";
            //            break;
            //        case 2:
            //            computer = "PAPER";
            //            break;
            //        case 3:
            //            computer = "SCISSORS";
            //            break;
            //    }
            //    Console.WriteLine("Computer : " + computer);
            //    Console.WriteLine("Player : " + player);

            //    switch (player)
            //    {
            //        case "ROCK":
            //            if(computer == "ROCK")
            //            {
            //                Console.WriteLine("It's draw");
            //            } 
            //            else if(computer == "PAPER")
            //            {
            //                Console.WriteLine("You lose");
            //            } 
            //            else
            //            {
            //                Console.WriteLine("You win");
            //            }
            //            break;
            //        case "PAPER":
            //            if (computer == "ROCK")
            //            {
            //                Console.WriteLine("You win");
            //            }
            //            else if (computer == "PAPER")
            //            {
            //                Console.WriteLine("It's draw");
            //            }
            //            else
            //            {
            //                Console.WriteLine("You lose");
            //            }
            //            break;
            //        case "SCISSORS":
            //            if (computer == "ROCK")
            //            {
            //                Console.WriteLine("You lose");
            //            }
            //            else if (computer == "PAPER")
            //            {
            //                Console.WriteLine("You win");
            //            }
            //            else
            //            {
            //                Console.WriteLine("It's draw");
            //            }
            //            break;
            //    }
            //}



            // --------- Array ---------


            //string[] cars = { "Audi", "BMW", "VOLVO" };
            //Console.WriteLine(cars[2]);

            // ------- ForEach Method ---------

            //foreach(string car in cars)
            //{
            //    Console.WriteLine(car);
            //}







            //  -------------- Methods ----------------
            Console.WriteLine("-------- Methods ---------");

            addNum(5, 10);
            double num = addNum(6, 10, 24);
            Console.WriteLine("Value of second addNum function " + num);

            double checkoutPrice = checkOut(12, 13.4, 21, 5.69);
            Console.WriteLine("Checkout price is : " + checkoutPrice);



            Console.ReadKey();
        }
        // ---------- Methods (function) ----------
        static void addNum(int num1, int num2)
        {
            Console.WriteLine("Adding two numbers using function : ");
            Console.WriteLine("Ans : " +( num1 + num2));
        }
        static double addNum(double num1, double num2, double num3)
        {
            double num4 = num1 + num2 + num3;
            return num4;
        }

        static double checkOut(params double[] prices)
        {
            double total = 0;
            foreach(double price in prices)
            {
                total += price;
            }
            return total;

            
        }
    }
}
