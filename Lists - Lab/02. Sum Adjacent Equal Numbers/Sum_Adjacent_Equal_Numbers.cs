using System;
using System.Linq;

namespace _02._Sum_Adjacent_Equal_Numbers
{
    public class Sum_Adjacent_Equal_Numbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                double current = numbers[i];
                double next = numbers[i + 1];
                if (current == next)
                {
                    numbers[i] = current + next;
                    numbers.RemoveAt(i + 1);
                    i = -1;
                }
            }

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
