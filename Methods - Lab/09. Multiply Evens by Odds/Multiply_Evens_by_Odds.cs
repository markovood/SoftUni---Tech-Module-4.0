using System;

namespace _09._Multiply_Evens_by_Odds
{
    public class Multiply_Evens_by_Odds
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int result = GetMultipleOfEvenAndOdds(Math.Abs(number));
            Console.WriteLine(result);
        }

        private static int GetMultipleOfEvenAndOdds(int number)
        {
            int sumOfEven = GetSumOfEvenDigits(number);
            int sumOfOdd = GetSumOfOddDigits(number);

            return sumOfEven * sumOfOdd;
        }

        private static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }

                number /= 10;
            }

            return sum;
        }

        private static int GetSumOfOddDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }

                number /= 10;
            }

            return sum;
        }
    }
}
