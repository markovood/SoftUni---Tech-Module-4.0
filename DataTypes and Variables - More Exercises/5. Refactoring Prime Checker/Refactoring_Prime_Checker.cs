using System;

namespace _5._Refactoring_Prime_Checker
{
    public class Refactoring_Prime_Checker
    {
        public static void Main()
        {
            int rangeUpperBound = int.Parse(Console.ReadLine());
            int rangeLowerBound = 2;

            for (int currentNumber = rangeLowerBound; currentNumber <= rangeUpperBound; currentNumber++)
            {
                bool isPrime = true;
                for (int divider = 2; divider < currentNumber; divider++)
                {
                    if (currentNumber % divider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                Console.WriteLine($"{currentNumber} -> {isPrime.ToString().ToLower()}");
            }

        }
    }
}
