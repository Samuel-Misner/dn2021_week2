using System;
using System.Collections.Generic;

namespace ArrayListPractice
{
    class Program
    {

        static List<string> CreateList(string first, string second, string third)
        {
            List<string> result = new List<string>();
            result.Add(first);
            result.Add(second);
            result.Add(third);
            return result;
        }

        static void PrintList(List<string> list)
        {
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }

        static string GetLast(List<string> list)
        {
            int length = list.Count;
            return list[length - 1];
        }

        static string GetArrayLast(string[] array)
        {
            int length = array.Length;
            return array[length - 1];
        }

        static void Plural(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] + "s";
            }
        }

        static int Average(List<int> nums)
        {
            int sum = 0;
            foreach (int item in nums)
            {
                sum += item;
            }
            return sum / nums.Count;
        }
        static void Main(string[] args)
        {
            List<string> words = CreateList("apple", "banana", "cranberry");
            PrintList(words);
            string last = GetLast(words);
            Console.WriteLine(last);

            string[] morewords = new string[] { "Fred", "Sally", "Julia" };
            string namelast = GetArrayLast(morewords);
            Console.WriteLine(namelast);

            Plural(morewords);
            foreach (string name in morewords)
            {
                Console.WriteLine(name);
            }

            List<int> mynumbers = new List<int>();
            mynumbers.Add(3);
            mynumbers.Add(4);
            mynumbers.Add(5);
            Console.WriteLine(Average(mynumbers));
        }
    }
}
