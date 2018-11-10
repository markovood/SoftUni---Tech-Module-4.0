using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    public class Legendary_Farming
    {
        public static void Main()
        {
            var junk = new Dictionary<string, int>();
            var keyMaterials = new Dictionary<string, int>()
            {
                ["shards"] = 0,
                ["fragments"] = 0,
                ["motes"] = 0
            };
            string legendaryObtained = string.Empty;

            while (true)
            {
                string[] tokens = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.ToLower())
                    .ToArray();
                
                int quantity = 0;
                for (int i = 0; i < tokens.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        quantity = int.Parse(tokens[i]);
                    }
                    else
                    {
                        string material = tokens[i];
                        if (keyMaterials.ContainsKey(material))
                        {
                            keyMaterials[material] += quantity;
                            if (keyMaterials[material] >= 250)
                            {
                                legendaryObtained = GetLegendary(material);
                                Console.WriteLine($"{legendaryObtained} obtained!");
                                keyMaterials[material] -= 250;
                                PrintRemainingKeyMaterial(keyMaterials);
                                PrintJunkItems(junk);
                                return;
                            }
                        }
                        else
                        {
                            if (junk.ContainsKey(material))
                            {
                                junk[material] += quantity;
                            }
                            else
                            {
                                junk.Add(material, quantity);
                            }
                        }
                    }
                }
            }

        }

        private static void PrintJunkItems(Dictionary<string, int> junk)
        {
            var orderedAlphabetically = junk.OrderBy(material => material.Key);
            foreach (var item in orderedAlphabetically)
            {
                string material = item.Key;
                int quantity = item.Value;
                Console.WriteLine($"{material}: {quantity}");
            }
        }

        private static void PrintRemainingKeyMaterial(Dictionary<string, int> keyMaterials)
        {
            var ordered = keyMaterials
                .OrderByDescending(material => material.Value)
                .ThenBy(material => material.Key);

            foreach (var item in ordered)
            {
                string material = item.Key;
                int quantity = item.Value;
                Console.WriteLine($"{material}: {quantity}");
            }
        }

        private static string GetLegendary(string keyMaterial)
        {
            string legendary = string.Empty;
            switch (keyMaterial)
            {
                case "shards":
                    legendary = "Shadowmourne";
                    break;
                case "fragments":
                    legendary = "Valanyr";
                    break;
                case "motes":
                    legendary = "Dragonwrath";
                    break;
            }

            return legendary;
        }
    }
}
