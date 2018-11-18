using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Letters_Change_Numbers
{
    public class Letters_Change_Numbers
    {
        public static void Main()
        {
            string[] inputStrs = Console.ReadLine()
                .Split(" \t\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            char[] alphabetCapitals = new char[]
            {
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N',
                'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
            };

            char[] alphabetSmalls = new char[]
            {
                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n',
                'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
            };

            List<double> results = new List<double>();

            for (int i = 0; i < inputStrs.Length; i++)
            {
                string currentStr = inputStrs[i];

                char firstLetter = currentStr[0];
                char lastLetter = currentStr[currentStr.Length - 1];
                long number = long.Parse(currentStr.Trim(firstLetter, lastLetter));

                int letterPosition = 0;
                double result = 0;
                if (char.IsUpper(firstLetter))
                {
                    letterPosition = Array.IndexOf(alphabetCapitals, firstLetter) + 1;
                    result = (double)number / letterPosition;
                }
                else
                {
                    letterPosition = Array.IndexOf(alphabetSmalls, firstLetter) + 1;
                    result = (double)number * letterPosition;
                }

                if (char.IsUpper(lastLetter))
                {
                    letterPosition = Array.IndexOf(alphabetCapitals, lastLetter) + 1;
                    result -= letterPosition;
                }
                else
                {
                    letterPosition = Array.IndexOf(alphabetSmalls, lastLetter) + 1;
                    result += letterPosition;
                }

                results.Add(result);
            }

            double sum = results.Sum();
            Console.WriteLine($"{sum:f2}");
        }
    }
}
