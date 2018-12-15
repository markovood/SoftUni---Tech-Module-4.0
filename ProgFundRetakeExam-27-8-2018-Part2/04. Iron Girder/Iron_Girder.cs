using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Iron_Girder
{
    public class Iron_Girder
    {
        public static void Main()
        {
            var townsAndFastestTimes = new Dictionary<string, int>();
            var townsAndTotalPassangers = new Dictionary<string, int>();
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Slide rule")
                {
                    break;
                }

                string[] lineTokens = line.Split(new string[] { ":", "->" }, StringSplitOptions.RemoveEmptyEntries);
                string townName = lineTokens[0];
                int time = 0;
                if (lineTokens[1] != "ambush")
                {
                    time = int.Parse(lineTokens[1]);
                }

                int passangersCount = int.Parse(lineTokens[2]);

                if (time != 0)// command is not ambush
                {
                    if (townsAndFastestTimes.ContainsKey(townName))
                    {
                        if (townsAndFastestTimes[townName] > time || townsAndFastestTimes[townName] == 0)
                        {
                            townsAndFastestTimes[townName] = time;
                        }

                        townsAndTotalPassangers[townName] += passangersCount;
                    }
                    else
                    {
                        townsAndFastestTimes.Add(townName, time);
                        townsAndTotalPassangers.Add(townName, passangersCount);
                    }
                }
                else// command is ambush
                {
                    if (townsAndFastestTimes.ContainsKey(townName))
                    {
                        townsAndFastestTimes[townName] = 0;
                        townsAndTotalPassangers[townName] -= passangersCount;
                    }
                }
            }

            // print
            var orderedByBestTime = townsAndFastestTimes
                .OrderBy(x => x.Value)
                .ThenBy(x => x.Key);
            foreach (var item in orderedByBestTime)
            {
                string townName = item.Key;
                int fastestTime = item.Value;
                int totalCountPassengers = townsAndTotalPassangers[townName];
                if (fastestTime == 0 || totalCountPassengers <= 0)
                {
                    continue;
                }

                Console.WriteLine($"{townName} -> Time: {fastestTime} -> Passengers: {totalCountPassengers}");
            }
        }
    }
}
