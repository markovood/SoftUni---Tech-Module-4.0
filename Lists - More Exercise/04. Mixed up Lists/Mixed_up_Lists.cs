using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Mixed_up_Lists
{
    public class Mixed_up_Lists
    {
        public static void Main()
        {
            List<int> firstList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> secondList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> mixed = new List<int>();
            int shorterLength = Math.Min(firstList.Count, secondList.Count);

            // fill up mixed list
            for (int firstListIndex = 0, secondListIndex = secondList.Count - 1;
                firstListIndex < shorterLength;
                firstListIndex++, secondListIndex--)
            {
                mixed.Add(firstList[firstListIndex]);
                mixed.Add(secondList[secondListIndex]);
            }

            // clear up the two lists
            for (int i = 0; i < shorterLength; i++)
            {
                firstList.RemoveAt(0);
                secondList.RemoveAt(secondList.Count - 1);
            }

            int firstRangeBound = 0;
            int secondRangeBound = 0;
            if (firstList.Count > secondList.Count)
            {
                firstRangeBound = firstList[0];
                secondRangeBound = firstList[1];
            }
            else
            {
                firstRangeBound = secondList[0];
                secondRangeBound = secondList[1];
            }

            // set the lower and upper bounds of range
            if (firstRangeBound > secondRangeBound)
            {
                int temp = firstRangeBound;
                firstRangeBound = secondRangeBound;
                secondRangeBound = temp;
            }


            List<int> result = new List<int>();
            for (int i = 0; i < mixed.Count; i++)
            {
                if (mixed[i] > firstRangeBound && mixed[i] < secondRangeBound)
                {
                    result.Add(mixed[i]);
                }
            }

            result.Sort();
            Console.WriteLine(string.Join(' ', result));
        }
    }
}
