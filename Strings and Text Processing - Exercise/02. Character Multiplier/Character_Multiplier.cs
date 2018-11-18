using System;

namespace _02._Character_Multiplier
{
    public class Character_Multiplier
    {
        public static void Main()
        {
            string[] inputStrs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string firstStr = inputStrs[0];
            string secondStr = inputStrs[1];

            int sum = MultiplyChars(firstStr, secondStr);
            Console.WriteLine(sum);
        }

        private static int MultiplyChars(string firstStr, string secondStr)
        {
            string shorter = GetShorter(firstStr, secondStr);
            string longer = GetLonger(firstStr, secondStr);
            int sum = 0;
            for (int i = 0; i < shorter.Length; i++)
            {
                sum += shorter[i] * longer[i];
            }

            for (int i = shorter.Length; i < longer.Length; i++)
            {
                sum += longer[i];
            }

            return sum;
        }

        private static string GetLonger(string firstStr, string secondStr)
        {
            if (secondStr.Length >= firstStr.Length)
            {
                return secondStr;
            }
            else
            {
                return firstStr;
            }
        }

        private static string GetShorter(string firstStr, string secondStr)
        {
            if (firstStr.Length <= secondStr.Length)
            {
                return firstStr;
            }
            else
            {
                return secondStr;
            }
        }
    }
}
