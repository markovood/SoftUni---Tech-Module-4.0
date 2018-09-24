using System;
using System.Linq;

namespace _06._Strong_number
{
    public class Strong_number
    {
        public static void Main()
        {
            string numberAsStr = Console.ReadLine();
            int sum = 0;

            foreach (var digitAsChar in numberAsStr)
            {
                int digit = int.Parse(digitAsChar.ToString());
                sum += Factorial(digit);
            }

            int number = int.Parse(numberAsStr);
            if (sum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }

        private static int Factorial(int i)
        {
            if (i <= 1)
            {
                return 1;
            }

            return i * Factorial(i - 1);
        }
    }
}
