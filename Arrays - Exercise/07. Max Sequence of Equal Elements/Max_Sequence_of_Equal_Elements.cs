using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    public class Max_Sequence_of_Equal_Elements
    {
        public static void Main()
        {
            int[] someArray = Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToArray();

            int longestSeq = 1;
            int longestSeqLastIndex = 0;
            int longestSeqElementValue = someArray[0];
            int currentLongestSeq = 1;
            
            // 2 1 1 2 3 3 2 2 2 1           4 4 4 4        0 1 1 5 2 2 6 3 3
            for (int i = 1; i < someArray.Length; i++)
            {
                if (someArray[i - 1] == someArray[i])
                {
                    currentLongestSeq++;    
                    longestSeqLastIndex = i;
                    if (currentLongestSeq > longestSeq)
                    {
                        longestSeq = currentLongestSeq;
                        longestSeqElementValue = someArray[longestSeqLastIndex];
                    }
                }
                else
                {
                    currentLongestSeq = 1;
                }
            }

            for (int i = 0; i < longestSeq; i++)
            {
                Console.Write(longestSeqElementValue + " ");
            }
        }
    }
}
