using System;

namespace _01._Sign_of_Integer_Numbers
{
    public class Sign_of_Integer_Numbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintSign(n);
        }

        private static void PrintSign(int n)
        {
            string sign = string.Empty;
            if (n < 0)
            {
                sign = "negative";
            }
            else if (n == 0)
            {
                sign = "zero";
            }
            else
            {
                sign = "positive";
            }

            Console.WriteLine($"The number {n} is {sign}.");
        }
    }
}
