using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._ForceBook
{
    public class ForceBook
    {
        public static void Main()
        {
            var forceMap = new Dictionary<string, SortedSet<string>>();
            var forceUsers = new HashSet<string>();
            var sides = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Lumpawaroo")
                {
                    break;
                }

                if (input.IndexOf(" | ") >= 0)
                {
                    // If you receive forceSide | forceUser you should check if such forceUser already exists,
                    // and if not, add him/her to the corresponding side.
                    string[] inputDetails = input.Split(" | ");
                    string forceSide = inputDetails[0];
                    string forceUser = inputDetails[1];
                    if (!forceUsers.Contains(forceUser))
                    {
                        if (forceMap.ContainsKey(forceSide))
                        {
                            forceMap[forceSide].Add(forceUser);
                        }
                        else
                        {
                            forceMap.Add(forceSide, new SortedSet<string>() { forceUser});
                        }
                    }

                    forceUsers.Add(forceUser);
                    if (!sides.Contains(forceSide))
                    {
                        sides.Add(forceSide);
                    }
                }
                else
                {
                    // If you receive a forceUser -> forceSide you should check if there is such forceUser
                    // already and if so, change his/her side. If there is no such forceUser, add him/her to the
                    // corresponding forceSide, treating the command as new registered forceUser. 
                    string[] inputDetails = input.Split(" -> ");
                    string forceUser = inputDetails[0];
                    string forceSide = inputDetails[1];
                    if (forceUsers.Contains(forceUser))
                    {
                        // change his side
                        string userCurrentSide = string.Empty;
                        string userNewSide = string.Empty;
                        foreach (var key in forceMap.Keys)
                        {
                            if (forceMap[key].Contains(forceUser))
                            {
                                userCurrentSide = key;
                            }
                            else
                            {
                                userNewSide = key;
                            }
                        }

                        forceMap[userCurrentSide].Remove(forceUser);
                        forceMap[userNewSide].Add(forceUser);
                    }
                    else
                    {
                        if (forceMap.ContainsKey(forceSide))
                        {
                            forceMap[forceSide].Add(forceUser);
                        }
                        else
                        {
                            forceMap.Add(forceSide, new SortedSet<string>() { forceUser });
                        }
                    }

                    // Then you should print on the console: "{forceUser} joins the {forceSide} side!"
                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                    forceUsers.Add(forceUser);
                    if (!sides.Contains(forceSide))
                    {
                        sides.Add(forceSide);
                    }
                }
            }

            // print each force side, ordered descending by forceUsers count, than ordered by name. For each
            // side print the forceUsers, ordered by name. In case there are no forceUsers in a side, you
            // shouldn`t print the side information

            var ordered = forceMap.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key);
            foreach (var item in ordered)
            {
                string forceSide = item.Key;
                var members = item.Value;
                if (members.Count > 0)
                {
                    Console.WriteLine($"Side: {forceSide}, Members: {members.Count}");
                    foreach (var member in members)
                    {
                        Console.WriteLine($"! {member}");
                    } 
                }
            }
        }
    }
}
