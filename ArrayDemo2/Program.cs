using System;

namespace ArrayDemo2
{
    class Program
    {
        static void DisplayMenu(string[] menuItems, decimal[] menuPrices)
        {
            Console.WriteLine("Here is our menu:\n");
            for (int i = 0; i < menuItems.Length; i++)
            {
                Console.WriteLine($"{menuItems[i],-12}{menuPrices[i],6}");
            }
        }

        static int FindItemIndex(string[] menuItems, string search)
        {
            for (int i = 0; i < menuItems.Length; i++)
            {
                if (menuItems[i].ToLower() == search.ToLower())
                {
                    return i;
                }
            }
            return -1;
        }
        
        static void Main(string[] args)
        {
            /*
             * 
             *   Create a men used at a coffee house
             * 
             *          Item                Price
             *          ----                -----
             *          Coffee              2.00
             *          Espresso            2.50
             *          Muffin              3.50
             *          Croissant           4.00
             *          
             */

            string[] items = new string[] { "Coffee", "Espresso", "Muffin", "Croissant" };
            decimal[] prices = new decimal[] { 2.00m, 2.50m, 3.50m, 4.00m };

            DisplayMenu(items, prices);

            Console.Write("\nPlease make a selection: ");

            string entry = "";

            bool validInput = false;
            while (!validInput)
            {
                entry = Console.ReadLine();
                if (entry.ToLower() == "coffee" || entry.ToLower() == "espresso" || entry.ToLower() == "muffin" || entry.ToLower() == "croissant")
                {
                    validInput = true;
                }
                else
                {
                    Console.Write($"Sorry, we do not have {entry}, please make a valid selection: ");
                }
            }

            int index = FindItemIndex(items, entry);
            Console.WriteLine(index);

            Console.WriteLine($"The price of {items[index]} is {prices[index]}");
        }
    }
}
