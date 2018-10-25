using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Merging_Lists
{
    public class Merging_Lists
    {
        public static void Main()
        {
            var firstList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var secondList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var result = new List<int>();
            int shorter = Math.Min(firstList.Count, secondList.Count);
            for (int i = 0; i < shorter; i++)
            {
                result.Add(firstList[i]);
                result.Add(secondList[i]);
            }

            if (firstList.Count == shorter)
            {
                for (int i = shorter; i < secondList.Count; i++)
                {
                    result.Add(secondList[i]);
                }
            }
            else
            {
                for (int i = shorter; i < firstList.Count; i++)
                {
                    result.Add(firstList[i]);
                }
            }

            Console.WriteLine(string.Join(' ', result));
        }
    }
}
