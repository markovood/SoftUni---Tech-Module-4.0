using System;

namespace _05._Multiplication_Sign
{
    public class Multiplication_Sign
    {
        public static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            PrintProductSign(num1, num2, num3);
        }

        private static void PrintProductSign(int num1, int num2, int num3)
        {
            if (num1 < 0 && num2 > 0 && num3 > 0
                || num1 > 0 && num2 < 0 && num3 > 0
                || num1 > 0 && num2 > 0 && num3 < 0
                || num1 < 0 && num2 < 0 && num3 < 0)
            {
                Console.WriteLine("negative");
            }
            else if (num1 == 0
                || num2 == 0
                || num3 == 0)
            {
                Console.WriteLine("zero");
            }
            else
            {
                Console.WriteLine("positive");
            }
        }
    }
}
