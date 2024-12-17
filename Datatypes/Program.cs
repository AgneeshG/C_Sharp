namespace Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 10;
            //int b = 20;
            //int c = a + b;
            //Console.WriteLine("Integer value : "+c);

            //float num1 = 13.42f;
            //float num2 = 24.234f;
            //float num3 = num1 + num2;
            //float num4 = 3.421f / 5.1f;
            //Console.WriteLine("float number : " + num3);

            //long num5 = 10000000000;
            //long num6 = 321;
            //long num7 = num5 + num6;
            //Console.WriteLine("long : " + num7);

            //double num8 = 3.421;
            //double num9 = 5.1;
            //double num10 = num8 / num9;
            //Console.WriteLine("Double : " + num10);
            //Console.WriteLine("Float : " + num4);



            // Explicit conversion - large to samll
            float a = 13.234f;
            int b = (int)a;
            Console.WriteLine(b + " - " + b.GetType());
            // Implicit conversion - small to large
            int c = 15;
            long d = c;
            Console.WriteLine("long : " + d);
            Console.WriteLine("int " + c.GetType());
            Console.WriteLine("long " + d.GetType());

            float e = 6.234f;
            double f = e;
            Console.WriteLine(f + " - " + f.GetType());


            // Type conversion
            int A = 10;
            string data = A.ToString();
            Console.WriteLine(A + "-" + A.GetType());
            Console.WriteLine(data + "-" + data.GetType());


            string value1 = Console.ReadLine();
            string value2 = Console.ReadLine();
            int num1 = Int32.Parse(value1);
            int num2 = Int32.Parse(value2);

            int num3 = num1 + num2;
            Console.WriteLine(num3);



            // String manipulation
            string name = "Karthik";
            int age = 25;
            string location = "Tamilnadu";
            Console.WriteLine("Hi i am " + name + " my age is " + age + "from " + location);
            Console.WriteLine("Hi i am {0} my age is {1} from {2}", name, age, location);
            Console.WriteLine($"Hi i am {name} my age is {age} from {location}");



            // string methods

            // string operatins


            Console.WriteLine("Enter your age");
            string ageString = Console.ReadLine();
            int Age;
            bool result = int.TryParse(ageString, out Age);
            Console.WriteLine(result + " and " + Age);
            




        }
    }
}