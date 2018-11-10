using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Ranking
{
    public class Ranking
    {
        public static void Main()
        {
            // TODO: Refactoring and optimization
            var contestsAndPaswords = new Dictionary<string, string>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end of contests")
                {
                    break;
                }

                string[] lineTokens = line.Split(':', StringSplitOptions.RemoveEmptyEntries);
                string contest = lineTokens[0];
                string password = lineTokens[1];
                if (contestsAndPaswords.ContainsKey(contest))
                {
                    contestsAndPaswords[contest] = password;
                }
                else
                {
                    contestsAndPaswords.Add(contest, password);
                }
            }

            var usernameAndContestAndPoints = new Dictionary<string, Dictionary<string, int>>();
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end of submissions")
                {
                    break;
                }

                string[] lineTokens = line.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string contest = lineTokens[0];
                string password = lineTokens[1];
                string username = lineTokens[2];
                int points = int.Parse(lineTokens[3]);
                bool isValidContest = ValidateContest(contest, contestsAndPaswords);
                bool isValidPassword = ValidatePassword(password, contestsAndPaswords);
                if (isValidContest && isValidPassword)
                {
                    // save user, contest and points
                    if (usernameAndContestAndPoints.ContainsKey(username))
                    {
                        // check if contest is same 
                        if (usernameAndContestAndPoints[username].ContainsKey(contest))
                        {
                            // if so update his points only if more
                            if (points > usernameAndContestAndPoints[username][contest])
                            {
                                usernameAndContestAndPoints[username][contest] = points;
                            }
                        }
                        else
                        {
                            usernameAndContestAndPoints[username].Add(contest, points);
                        }
                    }
                    else
                    {
                        usernameAndContestAndPoints.Add(
                            username,
                            new Dictionary<string, int>()
                            {
                                [contest] = points
                            });
                    }
                }
            }

            // print the info for the user with the most points in the format "Best candidate is {user} with
            // total {total points} points." After that print all students ordered by their names. For each
            // user print each contest with the points in descending order

            // find totalPoints from all contests and define the user 
            int totalPoints = 0;
            var bestUser = new Dictionary<string, int>();
            foreach (var item in usernameAndContestAndPoints)
            {
                string userName = item.Key;
                foreach (var kvp in item.Value)
                {
                    totalPoints += kvp.Value;
                }

                if (bestUser.ContainsKey(userName))
                {
                    bestUser[userName] = totalPoints;
                }
                else
                {
                    bestUser.Add(userName, totalPoints);
                }

                totalPoints = 0;
            }

            // print Console.WriteLine($"Best candidate is {user} with total {totalPoints} points.")
            bestUser = bestUser.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            string user = bestUser.First().Key;
            int totalPts = bestUser.First().Value;
            Console.WriteLine($"Best candidate is {user} with total {totalPts} points.");

            // order all students by name(key)
            var ordered = usernameAndContestAndPoints.OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);
            // order all students by points
            var orderedByPts = new Dictionary<string, Dictionary<string, int>>();
            foreach (var item in ordered)
            {
                orderedByPts.Add(item.Key, item.Value
                                                .OrderByDescending(x => x.Value)
                                                .ToDictionary(x => x.Key, x => x.Value));
            }

            // print all students ordered by their names. For each user print each contest with the points in
            // descending order.
            PrintStudents(orderedByPts);
        }

        private static void PrintStudents(Dictionary<string, Dictionary<string, int>> collection)
        {
            Console.WriteLine("Ranking:");
            foreach (var studentInfo in collection)
            {
                string student = studentInfo.Key;
                Console.WriteLine($"{student}");
                foreach (var studentInfoValue in studentInfo.Value)
                {
                    string contest = studentInfoValue.Key;
                    int pts = studentInfoValue.Value;
                    Console.WriteLine($"#  {contest} -> {pts}");
                }
            }
        }

        private static bool ValidatePassword(string passwordToValidate, Dictionary<string, string> fromDictionary)
        {
            if (fromDictionary.ContainsValue(passwordToValidate))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool ValidateContest(string contestToValidate, Dictionary<string, string> fromDictionary)
        {
            if (fromDictionary.ContainsKey(contestToValidate))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
