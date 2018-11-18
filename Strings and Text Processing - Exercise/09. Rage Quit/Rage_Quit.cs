using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace _09._Rage_Quit
{
    public class Rage_Quit
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            
            string[] splittedStrs = SplitInput(input);
            int uniqueSymbols = GetNumberOfUniqueSymbols(splittedStrs);

            Console.WriteLine($"Unique symbols used: {uniqueSymbols}");

            StringBuilder result = new StringBuilder();
            for (int i = 0; i < splittedStrs.Length; i++)
            {
                string[] tokens = splittedStrs[i].Split("DELIMITTER");
                string currentStr = tokens[0];
                int repeatCount = int.Parse(tokens[1]);
                for (int j = 0; j < repeatCount; j++)
                {
                    result.Append(currentStr);
                }
            }

            Console.WriteLine(result);
        }

        private static int GetNumberOfUniqueSymbols(string[] inputSplitted)
        {
            HashSet<char> uniqueSymbols = new HashSet<char>();
            foreach (var str in inputSplitted)
            {
                string[] tokens = str.Split("DELIMITTER");
                string currentStr = tokens[0];
                int repeat = int.Parse(tokens[1]);

                if (repeat > 0)
                {
                    foreach (var symbol in currentStr)
                    {
                        if (!char.IsDigit(symbol))
                        {
                            uniqueSymbols.Add(symbol);
                        }
                    }
                }
            }

            return uniqueSymbols.Count;
        }

        private static string[] SplitInput(string input)
        {
            List<string> result = new List<string>();
            StringBuilder currentResult = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                char currentSymbol = input[i];
                if (char.IsDigit(currentSymbol))
                {
                    currentResult.Append("DELIMITTER");
                    if (i < input.Length - 1 && char.IsDigit(input[i + 1]))
                    {
                        currentResult.Append(input.Substring(i, 2));
                        result.Add(currentResult.ToString().ToUpper());
                        currentResult.Clear();
                        i++;
                    }
                    else
                    {
                        currentResult.Append(input[i]);
                        result.Add(currentResult.ToString().ToUpper());
                        currentResult.Clear();
                    }
                }
                else
                {
                    currentResult.Append(currentSymbol);
                }
            }

            return result.ToArray();
        }
    }
}
