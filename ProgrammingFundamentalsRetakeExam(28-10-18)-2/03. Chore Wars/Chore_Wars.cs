using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Chore_Wars
{
    public class Chore_Wars
    {
        public static void Main()
        {
            Dictionary<string, int> commandsAndTimes = new Dictionary<string, int>();
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "wife is happy")
                {
                    break;
                }

                string validCommand = GetCommand(line);

                if (validCommand != null)
                {
                    int time = 0;
                    foreach (var symbol in validCommand)
                    {
                        if (char.IsDigit(symbol))
                        {
                            time += symbol - '0';
                        }
                    }

                    switch (validCommand[0])
                    {
                        case '<':
                            validCommand = "Doing the dishes";
                            break;
                        case '[':
                            validCommand = "Cleaning the house";
                            break;
                        case '{':
                            validCommand = "Doing the laundry";
                            break;
                    }

                    if (commandsAndTimes.ContainsKey(validCommand))
                    {
                        commandsAndTimes[validCommand] += time;
                    }
                    else
                    {
                        commandsAndTimes.Add(validCommand, time);
                    }
                }
            }

            
            int dishesTime = commandsAndTimes.Where(x => x.Key == "Doing the dishes").SingleOrDefault().Value;
            int cleaningTime = commandsAndTimes.Where(x => x.Key == "Cleaning the house").SingleOrDefault().Value;
            int laundryTime = commandsAndTimes.Where(x => x.Key == "Doing the laundry").SingleOrDefault().Value;

            Console.WriteLine($"Doing the dishes - {dishesTime} min.");
            Console.WriteLine($"Cleaning the house - {cleaningTime} min.");
            Console.WriteLine($"Doing the laundry - {laundryTime} min.");
            
            int totalTime = commandsAndTimes.Values.Sum();
            Console.WriteLine($"Total - {totalTime} min.");
        }

        private static string GetCommand(string line)
        {
            int startIndexDishes = line.IndexOf('<');
            if (startIndexDishes >= 0)
            {
                int endIndexDishes = line.IndexOf('>', startIndexDishes);

                if (startIndexDishes >= 0 && endIndexDishes >= 0)
                {
                    // save command for dishes
                    // validate command e.g. R[A [F67G9C]6e3C@
                    string command = line.Substring(startIndexDishes, endIndexDishes - startIndexDishes + 1);
                    string validCommand = Validate(command);

                    return validCommand;
                }
            }

            int startIndexCleaning = line.IndexOf('[');
            if (startIndexCleaning >= 0)
            {
                int endIndexClening = line.IndexOf(']', startIndexCleaning);

                if (startIndexCleaning >= 0 && endIndexClening >= 0)
                {
                    // cleaning command
                    // validate
                    string command = line.Substring(startIndexCleaning, endIndexClening - startIndexCleaning + 1);
                    string validCommand = Validate(command);

                    return validCommand;
                }
            }

            int startIndexLaundry = line.IndexOf('{');
            if (startIndexLaundry >= 0)
            {
                int endIndexLaundry = line.IndexOf('}', startIndexLaundry);

                if (startIndexLaundry >= 0 && endIndexLaundry >= 0)
                {
                    // laundry command
                    // validate
                    string command = line.Substring(startIndexLaundry, endIndexLaundry - startIndexLaundry + 1);
                    string validCommand = Validate(command);

                    return validCommand;
                }
            }

            return null;
        }

        private static string Validate(string command)
        {
            char commandChar = command[0];
            int sameCharIndex = command.IndexOf(commandChar, 1);
            if (sameCharIndex >= 0)
            {
                command = command.Remove(0, sameCharIndex);//nb -1
            }

            switch (commandChar)
            {
                case '<':
                    // has only lowercase letters and digits.
                    for (int i = 1; i < command.Length - 1; i++)
                    {
                        char currentSymbol = command[i];
                        if (!char.IsLetterOrDigit(currentSymbol))
                        {
                            return null;
                        }
                        else
                        {
                            if (char.IsLetter(currentSymbol))
                            {
                                if (!char.IsLower(currentSymbol))
                                {
                                    return null;
                                }
                            }
                        }
                    }

                    break;
                case '[':
                    // has only uppercase letters and digits.
                    for (int i = 1; i < command.Length - 1; i++)
                    {
                        char currentSymbol = command[i];
                        if (!char.IsLetterOrDigit(currentSymbol))
                        {
                            return null;
                        }
                        else
                        {
                            if (char.IsLetter(currentSymbol))
                            {
                                if (!char.IsUpper(currentSymbol))
                                {
                                    return null;
                                }
                            }
                        }
                    }

                    break;
                case '{':
                    // has any character in the middle.
                    break;
            }

            return command;
        }
    }
}
