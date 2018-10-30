using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    public class Count_Real_Numbers
    {
        public static void Main()
        {
            List<double> numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            var numbersCount = new SortedDictionary<double, int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                double currentNumber = numbers[i];
                if (numbersCount.ContainsKey(currentNumber))
                {
                    numbersCount[currentNumber]++;
                }
                else
                {
                    numbersCount.Add(currentNumber, 1);
                }
            }

            foreach (var item in numbersCount)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
