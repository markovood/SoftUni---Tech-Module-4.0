using System;
using System.Linq;

namespace _05._List_Manipulation_Basics
{
    public class List_Manipulation_Basics
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] commandDetails = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                switch (commandDetails[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(commandDetails[1]));
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(commandDetails[1]));
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(commandDetails[1]));
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(commandDetails[2]), int.Parse(commandDetails[1]));
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
