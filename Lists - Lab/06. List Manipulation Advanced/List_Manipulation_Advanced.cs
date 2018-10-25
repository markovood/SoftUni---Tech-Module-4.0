using System;
using System.Linq;

namespace _06._List_Manipulation_Advanced
{
    public class List_Manipulation_Advanced
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            bool isModified = false;
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] commandDetails = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                switch (commandDetails[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(commandDetails[1]));
                        isModified = true;
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(commandDetails[1]));
                        isModified = true;
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(commandDetails[1]));
                        isModified = true;
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(commandDetails[2]), int.Parse(commandDetails[1]));
                        isModified = true;
                        break;
                    case "Contains":
                        if (numbers.Contains(int.Parse(commandDetails[1])))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        var evenNums = numbers.Where(n => n % 2 == 0);
                        Console.WriteLine(string.Join(' ', evenNums));
                        break;
                    case "PrintOdd":
                        var oddNums = numbers.Where(n => n % 2 != 0);
                        Console.WriteLine(string.Join(' ', oddNums));
                        break;
                    case "GetSum":
                        var sum = 0;
                        foreach (var num in numbers)
                        {
                            sum += num;
                        }

                        Console.WriteLine(sum);
                        break;
                    case "Filter":
                        string condition = commandDetails[1];
                        int number = int.Parse(commandDetails[2]);
                        switch (condition)
                        {
                            case "<":
                                var filtered = numbers.Where(n => n < number);
                                string numbersLessThan = string.Join(' ', filtered);
                                Console.WriteLine(numbersLessThan);
                                break;
                            case ">":
                                filtered = numbers.Where(n => n > number);
                                string numbersGreaterThan = string.Join(' ', filtered);
                                Console.WriteLine(numbersGreaterThan);
                                break;
                            case "<=":
                                filtered = numbers.Where(n => n <= number);
                                string numbersLessThanOrEqual = string.Join(' ', filtered);
                                Console.WriteLine(numbersLessThanOrEqual);
                                break;
                            case ">=":
                                filtered = numbers.Where(n => n >= number);
                                string numbersGreaterThanOrEqual = string.Join(' ', filtered);
                                Console.WriteLine(numbersGreaterThanOrEqual);
                                break;
                        }
                        break;
                }

                command = Console.ReadLine();
            }

            if (isModified)
            {
                string numbersAsStr = string.Join(' ', numbers);
                Console.WriteLine(numbersAsStr);
            }
        }
    }
}
