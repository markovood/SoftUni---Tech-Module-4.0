namespace _02._Judge
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Judge
    {
        public static void Main()
        {
            var contestsAndStatistics = new Dictionary<string, Dictionary<string, int>>();
            while (true)
            {
                string line = Console.ReadLine();

                if (line == "no more time")
                {
                    break;
                }

                string[] lineTokens = line.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string username = lineTokens[0];
                string contest = lineTokens[1];
                int points = int.Parse(lineTokens[2]);

                if (contestsAndStatistics.ContainsKey(contest))
                {
                    if (contestsAndStatistics[contest].ContainsKey(username))
                    {
                        if (points > contestsAndStatistics[contest][username])
                        {
                            contestsAndStatistics[contest][username] = points;
                        }
                    }
                    else
                    {
                        contestsAndStatistics[contest].Add(username, points);
                    }
                }
                else
                {
                    contestsAndStatistics.Add(contest, new Dictionary<string, int>() { [username] = points });
                }
            }

            var individualStatistics = new Dictionary<string, int>();
            foreach (var contest in contestsAndStatistics)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");
                var ordered = contest.Value
                    .OrderByDescending(p => p.Value)
                    .ThenBy(p => p.Key);

                int position = 1;
                foreach (var participant in ordered)
                {
                    Console.WriteLine($"{position}. {participant.Key} <::> {participant.Value}");
                    position++;
                    if (individualStatistics.ContainsKey(participant.Key))
                    {
                        individualStatistics[participant.Key] += participant.Value;
                    }
                    else
                    {
                        individualStatistics.Add(participant.Key, participant.Value);
                    }
                }
            }

            // individual statistics
            Console.WriteLine($"Individual standings:");
            var individualStatisticsOrdered = individualStatistics
                .OrderByDescending(p => p.Value)
                .ThenBy(p => p.Key);

            int count = 1;
            foreach (var person in individualStatisticsOrdered)
            {
                Console.WriteLine($"{count}. {person.Key} -> {person.Value}");
                count++;
            }
        }
    }
}
