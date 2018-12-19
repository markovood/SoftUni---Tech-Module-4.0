using System;
using System.Collections.Generic;
using System.Linq;

namespace Concert
{
    public class Concert
    {
        public static void Main()
        {
            Dictionary<string, List<string>> bandsAndMembers = new Dictionary<string, List<string>>();
            Dictionary<string, long> bandsAndTimes = new Dictionary<string, long>();
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "start of concert")
                {
                    break;
                }

                // "Add; {bandName}; {member 1}, {member 2}, {member 3}"
                // "Play; {bandName}; {time}"
                string[] lineTokens = line.Split("; ", StringSplitOptions.RemoveEmptyEntries);
                if (lineTokens[0] == "Add")
                {
                    List<string> bandMembers = lineTokens[2]
                        .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                        .ToList();
                    string bandName = lineTokens[1];

                    if (bandsAndMembers.ContainsKey(bandName))
                    {
                        foreach (var member in bandMembers)
                        {
                            if (!bandsAndMembers[bandName].Contains(member))
                            {
                                bandsAndMembers[bandName].Add(member);
                            }
                        }
                    }
                    else
                    {
                        bandsAndMembers.Add(bandName, new List<string>(bandMembers));
                        bandsAndTimes.Add(bandName, 0);
                    }
                }
                else if (lineTokens[0] == "Play")
                {
                    string bandName = lineTokens[1];
                    int time = int.Parse(lineTokens[2]);

                    if (bandsAndTimes.ContainsKey(bandName))
                    {
                        bandsAndTimes[bandName] += time;
                    }
                    else
                    {
                        bandsAndTimes.Add(bandName, time);
                        bandsAndMembers.Add(bandName, new List<string>());
                    }
                }
            }

            long totalTime = bandsAndTimes.Values.Sum();
            Console.WriteLine($"Total time: {totalTime}");
            var ordered = bandsAndTimes
                .OrderByDescending(t => t.Value)
                .ThenBy(n => n.Key);

            foreach (var bandAndTime in ordered)
            {
                string band = bandAndTime.Key;
                long time = bandAndTime.Value;
                Console.WriteLine($"{band} -> {time}");
            }

            string bandNameToPrint = Console.ReadLine();
            Console.WriteLine(bandNameToPrint);
            foreach (var member in bandsAndMembers[bandNameToPrint])
            {
                Console.WriteLine($"=> {member}");
            }
        }
    }
}
