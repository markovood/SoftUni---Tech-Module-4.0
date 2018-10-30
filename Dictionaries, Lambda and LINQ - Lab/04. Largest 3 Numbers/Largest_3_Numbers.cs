using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Largest_3_Numbers
{
    public class Largest_3_Numbers
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var result = numbers
                .OrderByDescending(n => n)
                .Take(3);

            Console.WriteLine(string.Join(' ', result));
        }
    }
}
