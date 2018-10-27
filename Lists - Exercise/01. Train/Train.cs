using System;
using System.Linq;

namespace _01._Train
{
    public class Train
    {
        public static void Main()
        {
            var train = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int wagonMaxCapacity = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] commandDetails = command.Split(' ');
                switch (commandDetails[0])
                {
                    case "Add":
                        int wagon = int.Parse(commandDetails[1]);
                        train.Add(wagon);
                        break;
                    default:
                        for (int i = 0; i < train.Count; i++)
                        {
                            int currentWagon = train[i];
                            int passangersToAdd = int.Parse(commandDetails[0]);
                            if (currentWagon + passangersToAdd <= wagonMaxCapacity)
                            {
                                currentWagon += passangersToAdd;
                                train[i] = currentWagon;
                                break;
                            }
                        }
                        break;
                }

                command = Console.ReadLine();
            }

            string trainCurrentState = string.Join(' ', train);
            Console.WriteLine(trainCurrentState);
        }
    }
}
