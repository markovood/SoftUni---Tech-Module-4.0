using System;

namespace _2._From_Left_to_The_Right
{
    public class From_Left_to_The_Right
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] numbersAsStr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                long firstNumber = long.Parse(numbersAsStr[0]);
                long secondNumber = long.Parse(numbersAsStr[1]);

                if (firstNumber > secondNumber)
                {
                    // Math.Abs is used since number could be negative
                    Console.WriteLine(SumOfDigits(Math.Abs(firstNumber)));
                }
                else
                {
                    Console.WriteLine(SumOfDigits(Math.Abs(secondNumber)));
                }
            }
        }

        private static long SumOfDigits(long number)
        {
            long sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            return sum;
        }
    }
}
