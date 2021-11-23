using System;
using System.Collections.Generic;

namespace CollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("Fred");
            names.Add("Sally");

            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);

            names.Add("Julia");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine(names.Contains("Fred"));
            Console.WriteLine(names.Contains("Pizza"));

            names.Remove("Fred");

            Console.WriteLine(names[0]);
            names.RemoveAt(1);
            Console.WriteLine(names[0]);
            names.Add("Jack");
            names.Add("Allison");
            names.Add("Dylan");
            names.Add("Erica");

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}
