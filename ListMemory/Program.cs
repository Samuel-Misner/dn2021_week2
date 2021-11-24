using System;
using System.Collections.Generic;

namespace ListMemory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("Fred");
            names.Add("Sally");

            List<string> more;
            more = names;
            Console.WriteLine(more[0]);

            more[0] = "Frank";
            Console.WriteLine(names[0]);

            names.Add("Harold");

            Console.WriteLine("Print out the list names points to:");

            foreach (string word in names)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine("Print out the list more points to:");

            foreach (string word in more)
            {
                Console.WriteLine(word);
            }
        }
    }
}
