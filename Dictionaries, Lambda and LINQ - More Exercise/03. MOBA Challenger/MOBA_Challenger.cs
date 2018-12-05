using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._MOBA_Challenger
{
    public class MOBA_Challenger
    {
        public static void Main()
        {
            var playerPool = new Dictionary<string, Dictionary<string, int>>();
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Season end")
                {
                    break;
                }

                string[] lineTokens = null;

                if (line.IndexOf("->") >= 0)
                {
                    lineTokens = line.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                    string player = lineTokens[0];
                    string position = lineTokens[1];
                    int skills = int.Parse(lineTokens[2]);

                    if (playerPool.ContainsKey(player))
                    {
                        if (playerPool[player].ContainsKey(position))
                        {
                            if (playerPool[player][position] < skills)
                            {
                                playerPool[player][position] = skills;
                            }
                        }
                        else
                        {
                            playerPool[player].Add(position, skills);
                        }
                    }
                    else
                    {
                        playerPool.Add(player, new Dictionary<string, int>() { [position] = skills });
                    }
                }
                else
                {
                    lineTokens = line.Split(" vs ", StringSplitOptions.RemoveEmptyEntries);
                    string firstPlayer = lineTokens[0];
                    string secondPlayer = lineTokens[1];

                    if (playerPool.ContainsKey(firstPlayer) && playerPool.ContainsKey(secondPlayer))
                    {
                        // duel
                        foreach (var player in playerPool[firstPlayer])
                        {
                            string position = player.Key;
                            int skills = player.Value;
                            if (playerPool[secondPlayer].ContainsKey(position))
                            {
                                int totalSkills1 = playerPool[firstPlayer]
                                    .Values
                                    .Sum();

                                int totalSkills2 = playerPool[secondPlayer]
                                    .Values
                                    .Sum();
                                if (totalSkills1 > totalSkills2)
                                {
                                    // remove second player
                                    playerPool.Remove(secondPlayer);
                                }
                                else if (totalSkills2 > totalSkills1)
                                {
                                    // remove first player
                                    playerPool.Remove(firstPlayer);
                                }

                                break;
                            }
                        }
                    }
                }
            }

            var playersAndTotalSkills = new Dictionary<string, int>();
            foreach (var player in playerPool.Keys)
            {
                playersAndTotalSkills.Add(player, playerPool[player].Values.Sum());
            }

            var orderedPlayers = playersAndTotalSkills
                .OrderByDescending(p => p.Value)
                .ThenBy(p => p.Key);

            foreach (var player in orderedPlayers)
            {
                Console.WriteLine($"{player.Key}: {player.Value} skill");
                var orderedBySkillThenByPosition = playerPool[player.Key]
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key);

                foreach (var playerDetail in orderedBySkillThenByPosition)
                {
                    Console.WriteLine($"- {playerDetail.Key} <::> {playerDetail.Value}");
                }
            }
        }
    }
}
