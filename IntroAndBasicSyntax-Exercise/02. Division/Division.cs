using System;

namespace _02._Division
{
    public class Division
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            // 2, 3, 6, 7, 10.
            int biggestDivisor = 0;

            if (number % 2 == 0)
            {
                biggestDivisor = 2;
            }

            if (number % 3 == 0)
            {
                biggestDivisor = 3;
            }

            if (number % 6 == 0)
            {
                biggestDivisor = 6;
            }

            if (number % 7 == 0)
            {
                biggestDivisor = 7;
            }

            if (number % 10 == 0)
            {
                biggestDivisor = 10;
            }

            if (biggestDivisor != 0)
            {
                Console.WriteLine($"The number is divisible by {biggestDivisor}");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
