using System;
using System.Collections.Generic;

namespace ExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            names.Add("Fred");
            names.Add("Sally");
            names.Add("Julia");

            Console.WriteLine("Who is going next? Please enter a number: ");
            string entry = Console.ReadLine();
            int num;
            int.TryParse(entry, out num);

            try
            {
                Console.WriteLine(names[num]);
            }
            catch (Exception ex)
            {
                // The following commented out lines really aren't user-friendly.
                //Console.WriteLine("An error occurred!");
                //Console.WriteLine(ex.Message);
                Console.WriteLine($"Please enter a number between 0 and {names.Count - 1}");
            }
            Console.WriteLine(Convert.ToInt64("1100"));
        }
    }
}
