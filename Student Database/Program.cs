using System;

namespace Student_Database
{
    class Program
    {

        static void DisplayStudents(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }

        static int ValidStudent(string[] students, string student)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].ToLower() == student.ToLower())
                {
                    return i;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            string[] students = new string[] { "Samuel", "Matt", "Mark", "Brad", "David" };
            string[] town = new string[] { "Fort Wayne", "Chicago", "Detroit", "Los Angeles", "Atlanta" };
            string[] food = new string[] { "Pizza", "Ice Cream", "Potato Skins", "Steak", "Burger" };

            bool run = true;
            do
            {
                Console.WriteLine("\nHere is a list of students: \n");
                DisplayStudents(students);
                Console.Write("\nWhich student would you like to learn about? ");

                string userInput;
                int index;
                bool validInput = false;
                do
                {
                    userInput = Console.ReadLine();
                    index = ValidStudent(students, userInput);
                    if (index > -1)
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.Write("Please input a valid name: ");
                    }
                } while (!validInput);

                Console.WriteLine($"What information would you like to learn about {students[index]}? (Hometown / Favorite Food) ");

                validInput = false;
                do
                {
                    userInput = Console.ReadLine().ToLower();
                    if ("hometown".Contains(userInput))
                    {
                        Console.WriteLine($"{students[index]}'s Hometown is {town[index]}.");
                        validInput = true;
                    }
                    else if ("favorite food".Contains(userInput))
                    {
                        Console.WriteLine($"{students[index]}'s Favorite Food is {food[index]}.");
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry, I don't recognize that information type.");
                    }
                } while (!validInput);

                Console.Write("Would you like to find out information about another student? (y/n) ");

                validInput = false;
                do
                {
                    userInput = Console.ReadLine().ToLower();
                    if (userInput == "y")
                    {
                        validInput = true;
                    }
                    else if (userInput == "n")
                    {
                        validInput = true;
                        run = false;
                    }
                    else
                    {
                        Console.Write("I'm sorry, please enter (y/n) ");
                    }
                } while (!validInput);
            } while (run);
        }
    }
}
