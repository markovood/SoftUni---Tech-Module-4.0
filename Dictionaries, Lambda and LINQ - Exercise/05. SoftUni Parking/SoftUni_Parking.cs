using System;
using System.Collections.Generic;

namespace _05._SoftUni_Parking
{
    public class SoftUni_Parking
    {
        public static void Main()
        {
            var db = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] commandDetails = Console.ReadLine().Split(' ');

                switch (commandDetails[0])
                {
                    case "register":
                        string username = commandDetails[1];
                        string licensePlate = commandDetails[2];
                        if (db.ContainsKey(username))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {licensePlate}");
                        }
                        else
                        {
                            db.Add(username, licensePlate);
                            Console.WriteLine($"{username} registered {licensePlate} successfully");
                        }
                        break;
                    case "unregister":
                        username = commandDetails[1];
                        if (db.ContainsKey(username))
                        {
                            db.Remove(username);
                            Console.WriteLine($"{username} unregistered successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: user {username} not found");
                        }
                        break;
                }
            }

            foreach (var item in db)
            {
                string username = item.Key;
                string licensePlateNumber = item.Value;
                Console.WriteLine($"{username} => {licensePlateNumber}");
            }
        }
    }
}
