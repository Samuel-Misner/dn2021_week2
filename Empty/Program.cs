using System;

namespace Empty
{
    class Program
    {
        static bool GoAgain()
        {
            Console.WriteLine("Would you like to go again? (y/n) ");
            do
            {
                string entry = Console.ReadLine().ToLower();
                if (entry == "y")
                {
                    return true;
                }
                else if (entry == "n")
                {
                    return false;
                }
                else
                {
                    Console.Write("Please enter a valid input. (y/n) ");
                }
            }
            while (true);
        }
        static void Main(string[] args)
        {
            string[] names = new string[] { "Jeff", "Antonio", "Hanna", "Tommy" };
            string[] hometowns = new string[] { "Grand Rapids", "Detroit", "Seattle", "Raleigh" };
            string[] food = new string[] { "Pizza", "Focaccia Barese", "Shrimp", "Chicken Dumplings" };
            do
            {
                Console.Write("Which student would you like information on? ");
                string entry = Console.ReadLine();
                int num = int.Parse(entry);


                /*
                 *      We'll let the user start with 1 as the first, rather than the actual index 0 as the first
                 * 
                 *      Name    Index       What user enters
                 *      Jeff      0               1
                 *      Antonio   1               2
                 *      Hanna     2               3
                 *      Tommy     3               4
                 */

                num--;

                Console.WriteLine(names[num]);

                Console.Write("Which category? Please enter hometown or favorite food: ");
                entry = Console.ReadLine().ToLower();
                if (entry == "hometown")
                {
                    Console.WriteLine($"{names[num]} is from {hometowns[num]}");
                }
                else if (entry == "favorite food")
                {
                    Console.WriteLine($"{names[num]}'s favorite food is {food[num]}");
                }
            }
            while (GoAgain());
        }
    }
}
