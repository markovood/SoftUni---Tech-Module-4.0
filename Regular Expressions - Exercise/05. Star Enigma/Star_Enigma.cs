using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _05._Star_Enigma
{
    public class Star_Enigma
    {
        public static void Main()
        {
            string pattern = @"(?<=@)([A-Za-z]+)[^@\-!:>]*:[^@\-!:>0-9]*(\d+)![^@\-!:>]*([AD])[^@\-!:>AD]*![^@\-!:>]*->[^@\-!:>0-9]*(\d+)";
            int n = int.Parse(Console.ReadLine());
            List<Planet> attackedPlanets = new List<Planet>();
            List<Planet> destroyedPlanets = new List<Planet>();
            for (int i = 0; i < n; i++)
            {
                string encryptedMsg = Console.ReadLine();
                string decryptedMsg = Decrypt(encryptedMsg);
                Match msg = Regex.Match(decryptedMsg, pattern);
                if (msg.Success)
                {
                    var planet = new Planet(msg.Groups[1].Value, int.Parse(msg.Groups[2].Value), int.Parse(msg.Groups[4].Value));
                    string atackType = msg.Groups[3].Value;
                    switch (atackType)
                    {
                        case "A":
                            attackedPlanets.Add(planet);
                            break;
                        case "D":
                            destroyedPlanets.Add(planet);
                            break;
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (var planet in attackedPlanets.OrderBy(p => p.Name))
            {
                Console.WriteLine($"-> {planet}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (var planet in destroyedPlanets.OrderBy(p => p.Name))
            {
                Console.WriteLine($"-> {planet}");
            }
        }

        private static string Decrypt(string encryptedMsg)
        {
            var decriptSymbols = "star".ToCharArray().ToList();
            int count = 0;
            foreach (var symbol in encryptedMsg.ToLower())
            {
                if (decriptSymbols.Contains(symbol))
                {
                    count++;
                }
            }

            StringBuilder decryptedMsg = new StringBuilder();
            for (int i = 0; i < encryptedMsg.Length; i++)
            {
                decryptedMsg.Append((char)(encryptedMsg[i] - count));
            }

            return decryptedMsg.ToString();
        }
    }
}
