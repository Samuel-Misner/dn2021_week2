using System;
using System.Collections.Generic;

namespace Shopping_List
{
    class Program
    {

        static void DisplayMenu(Dictionary<string, decimal> dict)
        {
            int counter = 1;
            foreach (var pair in dict)
            {
                Console.WriteLine($"{counter, -2} {pair.Key, -12}{"$" + pair.Value, 8}");
                counter++;
            }
        }

        static bool GoAgain(string message)
        {
            Console.Write(message);

            bool validInput = false;
            bool returnValue = false;
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
            return returnValue;
        }
        static List<string> PopulateMenuItems(Dictionary<string, decimal> menu)
        {
            List<string> list = new List<string>();
            foreach (var pair in menu)
            {
                list.Add(pair.Key);
            }
            return list;
        }
        static List<string> ConvertPricesToItems(Dictionary<string, decimal> menu, List<decimal> prices)
        {
            List<string> returnList = new List<string>();
            for (int i = 0; i < prices.Count; i++)
            {
                foreach (var pair in menu)
                {
                    if (prices[i] == pair.Value)
                    {
                        returnList.Insert(i, pair.Key);
                    }
                }
            }
            return returnList;
        }
        static void Main(string[] args)
        {
            Dictionary<string, decimal> menu = new Dictionary<string, decimal>();
            menu["Apple"] = 0.99m;
            menu["Avocado"] = 0.75m;
            menu["Bacon"] = 1.25m;
            menu["Banana"] = 0.35m;
            menu["Ham"] = 3.49m;
            menu["Battery"] = 0.25m;
            menu["Popcorn"] = 1.09m;
            menu["Bread"] = 1.19m;

            List<string> menuItems = PopulateMenuItems(menu);
            List<string> cart = new List<string>();

            Console.WriteLine("Welcome to my store!\n\nHere's the menu:");

            do
            {
                Console.WriteLine("");
                DisplayMenu(menu);

                Console.Write("\nPlease enter the item you wish to add to your shopping cart: ");

                bool validInput = false;
                do
                {
                    string entry = Console.ReadLine();
                    int menuIndex = 0;
                    if (int.TryParse(entry, out menuIndex) && menuIndex >= 1 && menuIndex <= menu.Count)
                    {
                        menuIndex--;
                        validInput = true;
                        Console.WriteLine($"You have added {menuItems[menuIndex]} to your cart!");
                        cart.Add(menuItems[menuIndex]);
                    }
                    else
                    {
                        Console.Write($"I'm sorry, {entry} is not on our menu, please enter a different item: ");
                    }
                }
                while (!validInput);
            }
            while (GoAgain("Would you like to add another item to your shopping cart? (y/n) "));

            List<decimal> cartInPrices = new List<decimal>();

            foreach (string item in cart)
            {
                cartInPrices.Add(menu[item]);
            }

            cartInPrices.Sort();

            cart = ConvertPricesToItems(menu, cartInPrices);

            Console.WriteLine("\nHere is your shopping cart:\n");

            decimal total = 0;

            foreach (string item in cart)
            {
                Console.WriteLine($"{item, -12}{"$" + menu[item], 8}");
                total += menu[item];
            }

            Console.WriteLine($"\n{"Total", -12}{"$" + total, 8}");
        }
    }
}
