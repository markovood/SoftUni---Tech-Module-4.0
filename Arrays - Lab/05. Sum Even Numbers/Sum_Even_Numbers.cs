using System;
using System.Linq;

namespace _05._Sum_Even_Numbers
{
    public class Sum_Even_Numbers
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries).
                Select(n => int.Parse(n)).
                ToArray();

            int sum = 0;
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
