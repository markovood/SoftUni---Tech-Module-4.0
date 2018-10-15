using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Longest_Increasing_Subsequence
{
    public class Longest_Increasing_Subsequence
    {
        public static void Main()
        {
            // credits to https://www.youtube.com/watch?v=N-AlTemCnMc&t=24m55s

            int[] numbers = Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToArray();

            int[] len = new int[numbers.Length];
            int[] prev = new int[numbers.Length];

            int maxLen = 0;
            int lastIndex = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                len[i] = 1;
                prev[i] = -1;
                for (int j = 0; j <= i; j++)
                {
                    if ((numbers[i] > numbers[j]) && (len[j] + 1 > len[i]))
                    {
                        len[i] = len[j] + 1;
                        prev[i] = j;
                    }
                }

                if (len[i] > maxLen)
                {
                    maxLen = len[i];
                    lastIndex = i;
                }
            }

            int[] lis = RestoreLIS(numbers, prev, lastIndex);
            Console.WriteLine(string.Join(' ', lis));
        }

        public static int[] RestoreLIS(int[] seq, int[] prev, int lastIndex)
        {
            var longestSeq = new List<int>();
            while (lastIndex != -1)
            {
                longestSeq.Add(seq[lastIndex]);
                lastIndex = prev[lastIndex];
            }

            longestSeq.Reverse();
            return longestSeq.ToArray();
        }
    }
}
