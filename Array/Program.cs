using System.Collections;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5] { 1, 2, 3, 4, 5 };
            int[] num1 = new int[] { 10, 20, 30, 40, 50 };
            Console.WriteLine(num[2]);

            Console.WriteLine("foreach method :");
            foreach (int i in num)
            {
                Console.WriteLine(i);
            }



            Console.WriteLine("for loop method :");
            for (int i = 0; i < num1.Length; i++)
            {
                Console.WriteLine(num1[i]);
            }




            // ArrayList
            Console.WriteLine("------ ArrayList ------");
            ArrayList dataBook = new ArrayList();
            dataBook.Add(50);
            dataBook.Add(121);
            ArrayList dataBook2 = new ArrayList() { 1, 2, 3, 4, 1, "Animal", "Bird", 1, 243.4f, 50 };

            foreach (var item in dataBook)
            {
                Console.WriteLine(item);
            }
            dataBook2.Remove(50);
            dataBook2.RemoveAt(5);

            for (var item = 0; item < dataBook2.Count; item++)
            {
                Console.WriteLine(dataBook2[item]);
            }

            // List
            Console.WriteLine("------List-------");
            List<string> Animals = new List<string>();
            Animals.Add("Tiger");
            Animals.Add("Panda");
            List<string> Fruits = new List<string>() { "Apple", "Papaya", "Grape", "Orange", "Banana" };

            Fruits.Remove("Grape");
            Fruits.RemoveAt(2);
            foreach (var item in Animals)
            {
                Console.WriteLine(item);
            }

            for (var item = 0; item < Fruits.Count; item++)
            {
                Console.WriteLine(Fruits[item]);
            }


            //HashTable
            Console.WriteLine("-----HashTable------");

            Hashtable data = new Hashtable();
            data.Add("Name", "Karthik");
            data.Add(1, 24);
            data.Add("A1", 100);
            data.Add("age", 22);

            data.Remove("A1");
            foreach (DictionaryEntry item in data)
            {
                Console.WriteLine(item.Key);
            }



            //Dictionary
            Console.WriteLine("-------Dictionary-------");

            Dictionary<int, string> dataBook3 = new Dictionary<int, string>();
            dataBook3.Add(5, "Max");
            dataBook3.Add(6, "Sam");
            dataBook3.Add(7, "White");
            dataBook3.Add(8, "Snow");

            dataBook3.Remove(7);
            for (int i = 0; i < dataBook3.Count; i++)
            {
                Console.WriteLine($"{dataBook3.Keys.ElementAt(i)} : {dataBook3.Values.ElementAt(i)}");
            }

        }
        
    }
}