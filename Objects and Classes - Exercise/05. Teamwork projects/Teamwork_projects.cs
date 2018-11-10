using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Teamwork_projects
{
    public class Teamwork_projects
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split('-', StringSplitOptions.RemoveEmptyEntries);
                string creator = tokens[0];
                string teamName = tokens[1];

                if (teams.Any(x => x.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (teams.Any(x => x.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    var currentTeam = new Team(teamName, creator);
                    teams.Add(currentTeam);
                    Console.WriteLine($"Team {currentTeam.Name} has been created by {currentTeam.Creator}!");
                }
            }

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end of assignment")
                {
                    break;
                }

                string[] commandTokens = command.Split("->", StringSplitOptions.RemoveEmptyEntries);
                string user = commandTokens[0];
                string teamToJoin = commandTokens[1];

                if (!teams.Any(x => x.Name == teamToJoin))
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                }
                else if (teams.Any(x => x.Members.Contains(user)))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamToJoin}!");
                }
                else
                {
                    var team = teams.Find(x => x.Name == teamToJoin);
                    team.Members.Add(user);
                }

            }

            // Print
            foreach (var team in teams)
            {
                team.Members.Remove(team.Creator);
            }

            teams = teams
                    .OrderByDescending(x => x.Members.Count)
                    .ThenBy(x => x.Name)
                    .ToList();
            foreach (var team in teams)
            {
                if (team.Members.Count != 0)
                {
                    Console.WriteLine(team);
                }
            }

            Console.WriteLine("Teams to disband:");
            var disbandedTeams = teams
                .Where(x => x.Members.Count == 0)
                .OrderBy(x => x.Name);
            foreach (var team in disbandedTeams)
            {
                Console.WriteLine(team.Name);
            }

        }
    }
}
