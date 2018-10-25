using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Gauss__Trick
{
    public class Gauss__Trick
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var result = new List<int>();
            for (int i = 0, j = 1; i < numbers.Count / 2; i++, j++)
            {
                result.Add(numbers[i] + numbers[numbers.Count - j]);
            }

            if (numbers.Count % 2 != 0)
            {
                result.Add(numbers[numbers.Count / 2]);
                Console.WriteLine(string.Join(' ', result));
            }
            else
            {
                Console.WriteLine(string.Join(' ', result));
            }
        }
    }
}
