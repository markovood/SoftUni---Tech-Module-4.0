using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Exam_Results
{
    public class SoftUni_Exam_Results
    {
        public static void Main()
        {
            var submissionsAndCount = new Dictionary<string, int>();
            var userAndPoints = new Dictionary<string, int>();
            while (true)
            {
                string[] tokens = Console.ReadLine().Split('-');
                if (tokens[0] == "exam finished")
                {
                    break;
                }

                string username = tokens[0];
                if (tokens[1] == "banned")
                {
                    userAndPoints.Remove(username);
                }
                else
                {
                    string language = tokens[1];
                    int points = int.Parse(tokens[2]);
                    if (submissionsAndCount.ContainsKey(language))
                    {
                        submissionsAndCount[language]++;
                    }
                    else
                    {
                        submissionsAndCount.Add(language, 1);
                    }

                    if (userAndPoints.ContainsKey(username))
                    {
                        if (points > userAndPoints[username])
                        {
                            userAndPoints[username] = points;
                        }
                    }
                    else
                    {
                        userAndPoints.Add(username, points);
                    }
                }
            }

            // print each of the participants, ordered descending by their max points, then by username
            var orderedUsersAndPoints = userAndPoints.OrderByDescending(x => x.Value).ThenBy(x => x.Key);
            Console.WriteLine("Results:");
            foreach (var item in orderedUsersAndPoints)
            {
                string username = item.Key;
                int points = item.Value;
                Console.WriteLine($"{username} | {points}");
            }

            var orderedSubmissionsAndCounts = submissionsAndCount.OrderByDescending(x => x.Value).ThenBy(x => x.Key);
            Console.WriteLine("Submissions:");
            foreach (var item in orderedSubmissionsAndCounts)
            {
                string language = item.Key;
                int count = item.Value;
                Console.WriteLine($"{language} - {count}");
            }
        }
    }
}
