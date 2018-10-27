using System;
using System.Collections.Generic;

namespace _03._House_Party
{
    public class House_Party
    {
        private static List<string> guestList = new List<string>();

        public static void Main()
        {
            int numOfCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfCommands; i++)
            {
                string command = Console.ReadLine();
                ProccessCommand(command);
            }

            PrintGuestList();
        }

        private static void PrintGuestList()
        {
            foreach (var guest in guestList)
            {
                Console.WriteLine(guest);
            }
        }

        private static void ProccessCommand(string command)
        {
            string[] commandDetails = command.Split(' ');
            string name = commandDetails[0];
            bool isInTheList = IsInTheList(name);
            switch (commandDetails[2])
            {
                case "going!":
                    if (isInTheList)
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guestList.Add(name);
                    }
                    break;
                case "not":
                    if (IsInTheList(name))
                    {
                        guestList.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                    break;
            }
        }

        private static bool IsInTheList(string name)
        {
            return guestList.Contains(name);
        }
    }
}
