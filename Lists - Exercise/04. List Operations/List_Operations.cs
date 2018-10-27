using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    public class List_Operations
    {
        private static List<int> numbers;

        public static void Main()
        {
            numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();
            while (command != "End")
            {
                ProccessCommand(command);

                command = Console.ReadLine();
            }

            string numbersToString = string.Join(' ', numbers);
            Console.WriteLine(numbersToString);
        }

        private static void ProccessCommand(string command)
        {
            string[] commandDetails = command.Split(' ');
            switch (commandDetails[0])
            {
                case "Add":
                    int numberToAdd = int.Parse(commandDetails[1]);
                    numbers.Add(numberToAdd);
                    break;
                case "Insert":
                    int numberToInsert = int.Parse(commandDetails[1]);
                    int index = int.Parse(commandDetails[2]);
                    bool isValid = Validate(index);
                    if (isValid)
                    {
                        numbers.Insert(index, numberToInsert);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                    break;
                case "Remove":
                    index = int.Parse(commandDetails[1]);
                    isValid = Validate(index);
                    if (isValid)
                    {
                        numbers.RemoveAt(index);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                    break;
                case "Shift":
                    string direction = commandDetails[1];
                    int count = int.Parse(commandDetails[2]);
                    Shift(direction, count);
                    break;
            }
        }

        private static void Shift(string direction, int count)
        {
            // 1 23 29 18 43 21 20 
            // left -> first --> last  
            // right -> last --> first

            for (int i = 0; i < count; i++)
            {
                int firstIndex = 0;
                int lastIndex = numbers.Count - 1;
                int firstNumber = numbers[firstIndex];
                int lastNumber = numbers[lastIndex];
                if (direction == "left")
                {
                    numbers.RemoveAt(firstIndex);
                    numbers.Insert(lastIndex, firstNumber);
                }
                else
                {
                    numbers.RemoveAt(lastIndex);
                    numbers.Insert(firstIndex, lastNumber);
                }
            }

        }

        private static bool Validate(int index)
        {
            if (index < 0 || index >= numbers.Count)
            {
                return false;
            }

            return true;
        }
    }
}
