using System;

namespace _10._Top_Number
{
    public class Top_Number
    {
        public static void Main()
        {
            int endOfRange = int.Parse(Console.ReadLine());
            for (int i = 1; i <= endOfRange; i++)
            {
                if (IsValid(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool IsValid(int number)
        {
            // Its sum of digits is divisible by 8
            // Holds at least one odd digit

            int sumOfDigits = SumDigits(number);
            if (sumOfDigits % 8 == 0 && HasAnOddDigit(number))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool HasAnOddDigit(int number)
        {
            number = Math.Abs(number);
            int lastDigit;
            while (number > 0)
            {
                lastDigit = number % 10;
                if (lastDigit % 2 != 0)
                {
                    return true;
                }

                number /= 10;
            }

            return false;
        }

        private static int SumDigits(int number)
        {
            number = Math.Abs(number);
            int sum = 0;
            while(number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            return sum;
        }
    }
}
