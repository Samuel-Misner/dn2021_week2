using System;
using System.Collections.Generic;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> capitals = new Dictionary<string, string>();
            capitals["Michigan"] = "Lansing";
            capitals["Ohio"] = "Columbus";
            capitals["California"] = "Sacramento";
            capitals["Georgia"] = "Atlanta";

            Console.WriteLine("Let's print out a couple of these");
            Console.WriteLine(capitals["Ohio"]);
            Console.WriteLine(capitals["Georgia"]);

            foreach (var pair in capitals)
            {
                Console.WriteLine($"{pair.Key} {pair.Value}");
            }

            Console.WriteLine("");

            capitals["Indiana"] = "Indianapolis";
            foreach (var pair in capitals)
            {
                Console.WriteLine($"{pair.Key} {pair.Value}");
            }
        }
    }
}
