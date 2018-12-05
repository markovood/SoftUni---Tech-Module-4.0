using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Dragon_Army
{
    public class Dragon_Army
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var dragonTypesAndStats = new Dictionary<string, SortedDictionary<string, List<int>>>();
            for (int i = 0; i < n; i++)
            {
                string[] lineTokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string type = lineTokens[0];
                string name = lineTokens[1];
                int damage = 45;
                if (lineTokens[2] != "null")
                {
                    damage = int.Parse(lineTokens[2]);
                }

                int health = 250;
                if (lineTokens[3] != "null")
                {
                    health = int.Parse(lineTokens[3]);
                }

                int armour = 10;
                if (lineTokens[4] != "null")
                {
                    armour = int.Parse(lineTokens[4]);
                }

                if (dragonTypesAndStats.ContainsKey(type))
                {
                    if (dragonTypesAndStats[type].ContainsKey(name))
                    {
                        dragonTypesAndStats[type][name] = new List<int>() { damage, health, armour };
                    }
                    else
                    {
                        dragonTypesAndStats[type].Add(name, new List<int>() { damage, health, armour });
                    }
                }
                else
                {
                    dragonTypesAndStats.Add(type, new SortedDictionary<string, List<int>>()
                    {
                        [name] = new List<int>() { damage, health, armour }
                    });
                }
            }

            foreach (var type in dragonTypesAndStats)
            {
                string typeName = type.Key;
                double sumDamage = 0;
                double sumHealth = 0;
                double sumArmour = 0;
                int counter = 0;

                foreach (var dragon in dragonTypesAndStats[typeName])
                {
                    sumDamage += dragon.Value[0];
                    sumHealth += dragon.Value[1];
                    sumArmour += dragon.Value[2];
                    counter++;
                }

                double averageDamage = sumDamage / counter;
                double averageHealth = sumHealth / counter;
                double averageArmour = sumArmour / counter;

                Console.WriteLine($"{typeName}::({averageDamage:f2}/{averageHealth:f2}/{averageArmour:f2})");
                foreach (var dragon in dragonTypesAndStats[typeName])
                {
                    string name = dragon.Key;
                    int damage = dragon.Value[0];
                    int health = dragon.Value[1];
                    int armour = dragon.Value[2];
                    Console.WriteLine($"-{name} -> damage: {damage}, health: {health}, armor: {armour}");
                }
            }
        }
    }
}
