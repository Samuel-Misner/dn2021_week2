using System;

namespace SwitchDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter Pizza, Apple, or Coffee: ");
            string entry = Console.ReadLine().ToLower();
            /*
            if (entry == "pizza")
            {
                Console.WriteLine("Pizza is fun to have for dinner.");
            }
            else if (entry == "apple")
            {
                Console.WriteLine("An apple a day keeps the doctor away.");
            }
            else if (entry == "coffee")
            {
                Console.WriteLine("Coffee gets you going every morning.");
            }
            else
            {
                Console.WriteLine("I have no idea what that is!");
            }
            */

            switch (entry)
            {
                case "pizza":
                    Console.WriteLine("Pizza is fun to have for dinner.");
                    break;
                case "apple":
                    Console.WriteLine("An apple a day keeps the doctor away.");
                    break;
                case "coffee":
                    Console.WriteLine("Coffee gets you going every morning.");
                    break;
                default:
                    Console.WriteLine("I have no idea what that is!");
                    break;
            }
        }
    }
}
