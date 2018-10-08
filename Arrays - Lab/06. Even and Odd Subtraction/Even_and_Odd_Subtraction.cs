using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
{
    public class Even_and_Odd_Subtraction
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries).
                Select(n => int.Parse(n)).
                ToArray();

            int evenSum = 0;
            int oddSum = 0;
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenSum += number;
                }
                else
                {
                    oddSum += number;
                }
            }

            Console.WriteLine(evenSum - oddSum);
        }
    }
}
