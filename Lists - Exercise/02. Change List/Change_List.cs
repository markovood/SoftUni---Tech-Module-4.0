using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    public class Change_List
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
                ProccessCommand(command, numbers);

                command = Console.ReadLine();
            }

            string numbersAsStr = string.Join(' ', numbers);
            Console.WriteLine(numbersAsStr);
        }

        private static void ProccessCommand(string command, List<int> theList)
        {
            string[] commandDetails = command.Split(' ');
            switch (commandDetails[0])
            {
                case "Delete":
                    int valueToDelete = int.Parse(commandDetails[1]);
                    theList.RemoveAll(n => n == valueToDelete);
                    break;
                case "Insert":
                    int valueToInsert = int.Parse(commandDetails[1]);
                    int position = int.Parse(commandDetails[2]);
                    theList.Insert(position, valueToInsert);
                    break;
            }
        }
    }
}
