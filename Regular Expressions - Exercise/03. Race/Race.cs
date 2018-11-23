using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._Race
{
    public class Race
    {
        public static void Main()
        {
            string pattern = @"[A-Za-z0-9]+";
            List<string> participants = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> inputs = new List<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of race")
                {
                    break;
                }

                MatchCollection matches = Regex.Matches(input, pattern);
                string currentInput = string.Join("", matches);
                inputs.Add(currentInput);
            }

            Dictionary<string, int> runnersAndDistances = new Dictionary<string, int>();
            foreach (var input in inputs)
            {
                string runnerName = string.Empty;
                int distance = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    char symbol = input[i];
                    if (char.IsLetter(symbol))
                    {
                        runnerName += symbol;
                    }
                    else if (char.IsDigit(symbol))
                    {
                        distance += int.Parse(symbol.ToString());
                    }
                }

                if (participants.Contains(runnerName))
                {
                    if (runnersAndDistances.ContainsKey(runnerName))
                    {
                        runnersAndDistances[runnerName] += distance;
                    }
                    else
                    {
                        runnersAndDistances.Add(runnerName, distance);
                    }
                }
            }

            var result = runnersAndDistances
                            .OrderByDescending(r => r.Value)
                            .ToList();

            Console.WriteLine($"1st place: {result[0].Key}");
            Console.WriteLine($"2nd place: {result[1].Key}");
            Console.WriteLine($"3rd place: {result[2].Key}");
        }
    }
}
