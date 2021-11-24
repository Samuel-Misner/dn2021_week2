using System;
using System.Collections.Generic;

namespace Casino_Dice_Roller
{
    class Program
    {
        static Dictionary<string, int[]> GenerateRules(int max)
        {
            Dictionary<string, int[]> returnDictionary = new Dictionary<string, int[]>();
            returnDictionary.Add("Snake Eyes", new int[] { 2 });
            if (max > 1)
            {
                returnDictionary.Add("Ace Deuce", new int[] { 3 });
                returnDictionary.Add("Win", new int[] { (2 + (max * 2)) / 2, (max * 2) - 1 });
            }
            else
            {
                returnDictionary.Add("Ace Deuce", new int[] { -1 });
                returnDictionary.Add("Win", new int[] { (2 + (max * 2)) / 2 });
            }
            returnDictionary.Add("Box Cars", new int[] { max * 2 });
            returnDictionary.Add("Craps", new int[] { 2, 3, (max * 2) });
            return returnDictionary;
        }
        static List<int> RollDie(Random rand, int sides)
        {
            List<int> returnList = new List<int>();
            for (int i = 0; i < 2; i++)
            {
                returnList.Add(rand.Next(1, sides + 1));
            }
            return returnList;
        }
        static void PrintResults(Dictionary<string, int[]> rules, List<int> die)
        {
            int total = die[0] + die[1];
            foreach (var pair in rules)
            {
                foreach (int rule in pair.Value)
                {
                    if (total == rule)
                    {
                        Console.WriteLine($"{pair.Key}!");
                    }
                }
            }
        }
        static bool GoAgain()
        {
            bool returnValue = false;

            Console.Write("Would you like to roll again? (y/n) ");
            
            bool validInput = false;
            do
            {
                string entry = Console.ReadLine().ToLower();
                if (entry == "y")
                {
                    returnValue = true;
                    validInput = true;
                }
                else if (entry == "n")
                {
                    returnValue = false;
                    validInput = true;
                }
                else
                {
                    Console.Write("Please enter a valid input (y/n) ");
                }
            }
            while (!validInput);
            Console.WriteLine("");
            return returnValue;
        }
        static void Main(string[] args)
        {
            Random rand = new Random();

            Console.WriteLine("Welcome to my casino!\n");
            Console.Write("How many sides should each die have? ");

            int sides = 0;

            bool validInput = false;
            do
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out sides) && sides > 0)
                {
                    validInput = true;
                }
                else
                {
                    Console.Write("Please enter a valid non negative integer: ");
                }
            }
            while (!validInput);

            Console.WriteLine("");

            Dictionary<string, int[]> rulebook = GenerateRules(sides);

            int playCounter = 1;

            do
            {
                Console.WriteLine($"Roll {playCounter}:");
                List<int> rolledDie = RollDie(rand, sides);
                Console.WriteLine($"You rolled a {rolledDie[0]} and a {rolledDie[1]} ({rolledDie[0] + rolledDie[1]} total)");
                PrintResults(rulebook, rolledDie);
                Console.WriteLine("");
                playCounter++;
            }
            while (GoAgain());

            Console.WriteLine($"\nThanks for playing!");
        }
    }
}
