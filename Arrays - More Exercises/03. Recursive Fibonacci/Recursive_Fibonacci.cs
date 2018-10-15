using System;

namespace _03._Recursive_Fibonacci
{
    public class Recursive_Fibonacci
    {
        public static void Main()
        {
            int wantedFibonaciNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(GetFibonaci(wantedFibonaciNumber));
        }

        public static long GetFibonaci(int number)
        {
            if (number == 1 || number == 2)
            {
                return 1;
            }

            return GetFibonaci(number - 1) + GetFibonaci(number - 2);
        }
    }
}
