using System;
using System.Linq;

namespace _10._LadyBugs
{
    public class LadyBugs
    {
        public static void Main()
        {
            // set up the field
            int fieldLength = int.Parse(Console.ReadLine());
            int[] field = new int[fieldLength];

            // place the bugs on the field
            int[] initialBugsIndexes = Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToArray();
            for (int i = 0; i < initialBugsIndexes.Length; i++)
            {
                if (initialBugsIndexes[i] >= 0 && initialBugsIndexes[i] < field.Length)
                {
                    field[initialBugsIndexes[i]] = 1;
                }
            }


            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] commandDetails = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int ladyBugIndex = int.Parse(commandDetails[0]);
                string direction = commandDetails[1];
                int flyLength = int.Parse(commandDetails[2]);
                if (ladyBugIndex < 0 ||
                    ladyBugIndex > field.Length - 1 || 
                    field[ladyBugIndex] == 0)
                {
                    command = Console.ReadLine();
                    continue;
                }
                else
                {
                    ProcessCommand(ladyBugIndex, direction, flyLength, field);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', field));
        }

        private static void ProcessCommand(int index, string direction, int flyLength, int[] field)
        {
            switch (direction)
            {
                case "right":
                    field[index] = 0;
                    int nextIndex = index + flyLength;
                    // If the ladybug flies out of the field, it is gone.
                    if (nextIndex < field.Length)
                    {
                        // If the ladybug lands on a fellow ladybug, it continues to fly in the same direction by the same fly length.
                        if (field[nextIndex] == 1)
                        {
                            while (nextIndex < field.Length && field[nextIndex] == 1)
                            {
                                nextIndex += flyLength;
                            }

                            if (nextIndex < field.Length)
                            {
                                field[nextIndex] = 1;
                            }
                        }
                        else
                        {
                            field[nextIndex] = 1;
                        }
                    }
                    break;
                case "left":
                    field[index] = 0;
                    // If the ladybug flies out of the field, it is gone.
                    int nextLeftIndex = index - flyLength;
                    if (nextLeftIndex >= 0)
                    {
                        // If the ladybug lands on a fellow ladybug, it continues to fly in the same direction by the same fly length.
                        if (field[nextLeftIndex] == 1)
                        {
                            while (nextLeftIndex >= 0 && field[nextLeftIndex] == 1)
                            {
                                nextLeftIndex -= flyLength;
                            }

                            if (nextLeftIndex >= 0)
                            {
                                field[nextLeftIndex] = 1;
                            }
                        }
                        else
                        {
                            field[nextLeftIndex] = 1;
                        }
                    }
                    break;
            }
        }
    }
}
