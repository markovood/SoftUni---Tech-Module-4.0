using System;

namespace _08._Factorial_Division
{
    public class Factorial_Division
    {
        public static void Main()
        {
            int firstInt = int.Parse(Console.ReadLine());
            int secondInt = int.Parse(Console.ReadLine());

            long firstIntFactorial = CalculateFactorial(firstInt);
            long secondIntFactorial = CalculateFactorial(secondInt);
            double division = firstIntFactorial / (double)secondIntFactorial;
            Console.WriteLine($"{division:F2}");
        }

        private static long CalculateFactorial(int someInt)
        {
            if (someInt <= 1)
            {
                return 1;
            }

            return someInt * CalculateFactorial(someInt - 1);
        }
    }
}
