using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._TakeOrSkip_Rope
{
    public class TakeOrSkip_Rope
    {
        public static void Main()
        {
            string text = Console.ReadLine();

            List<int> numbers = new List<int>();
            List<char> nonNumbers = new List<char>();
            SeparateText(text, numbers, nonNumbers);

            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();
            SeparateTakeAndSkipLists(numbers, takeList, skipList);
            
            int skippedCount = 0;
            string result = string.Empty;
            for (int i = 0; i < takeList.Count; i++)
            {
                result += string.Join("", nonNumbers.Skip(skippedCount).Take(takeList[i]));
                skippedCount += skipList[i] + takeList[i];
            }

            Console.WriteLine(result);
        }

        private static void SeparateTakeAndSkipLists(List<int> fromList, List<int> toTakeList, List<int> toSkipList)
        {
            for (int i = 0; i < fromList.Count; i++)
            {
                int currentInt = fromList[i];
                if (i % 2 == 0)
                {
                    toTakeList.Add(currentInt);
                }
                else
                {
                    toSkipList.Add(currentInt);
                }
            }
        }

        private static void SeparateText(string textToSeparate, List<int> separatedNumbers, List<char> separatedNonNumbers)
        {
            for (int i = 0; i < textToSeparate.Length; i++)
            {
                char currentSymbol = textToSeparate[i];
                if (char.IsDigit(currentSymbol))
                {
                    separatedNumbers.Add(int.Parse(currentSymbol.ToString()));
                }
                else
                {
                    separatedNonNumbers.Add(currentSymbol);
                }
            }
        }
    }
}
