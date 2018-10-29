using System;
using System.Linq;

namespace _02._Car_Race
{
    public class Car_Race
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            double leftCarTime = GetTotalTime(numbers, "left");
            double rightCarTime = GetTotalTime(numbers, "right");
            string winner = string.Empty;
            double winnerTime = 0;
            if (leftCarTime < rightCarTime)
            {
                winner = "left";
                winnerTime = leftCarTime;
            }
            else
            {
                winner = "right";
                winnerTime = rightCarTime;
            }

            Console.WriteLine($"The winner is {winner} with total time: {winnerTime}");
        }

        private static double GetTotalTime(int[] numbers, string car)
        {
            int finishIndex = numbers.Length / 2;
            double totalTime = 0;
            switch (car)
            {
                case "left":
                    for (int i = 0; i < finishIndex; i++)
                    {
                        // If you have a zero in the array, you have to reduce the time of the racer that reached it by
                        // 20% (from the time so far).
                        totalTime += numbers[i];
                        if (numbers[i] == 0)
                        {
                            totalTime *= 0.8;
                        }
                    }
                    break;
                case "right":
                    for (int i = numbers.Length - 1; i > finishIndex; i--)
                    {
                        totalTime += numbers[i];
                        if (numbers[i] == 0)
                        {
                            totalTime *= 0.8;
                        }
                    }
                    break;
            }

            return totalTime;
        }
    }
}
