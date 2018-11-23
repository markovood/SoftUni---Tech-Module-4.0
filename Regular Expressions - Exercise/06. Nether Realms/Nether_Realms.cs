using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _06._Nether_Realms
{
    public class Nether_Realms
    {
        public static void Main()
        {
            List<Deamon> deamonsBook = new List<Deamon>();
            string splitPattern = @"[, ]+";
            string[] names = Regex.Split(Console.ReadLine(), splitPattern);

            foreach (var name in names)
            {
                string patternForHealth = @"[^0-9+\-*\/.]+";
                string healthMatch = string.Join("", Regex.Matches(name, patternForHealth));

                int health = 0;
                foreach (var symbol in healthMatch)
                {
                    health += symbol;
                }
                
                string patternBaseDamage = @"[\-\+]?\d+\.?\d*";
                MatchCollection numbers = Regex.Matches(name, patternBaseDamage);
                double baseDamage = 0;
                foreach (Match number in numbers)
                {
                    baseDamage += double.Parse(number.Value);
                }

                string patternAlterSymbols = @"[\/*]";
                MatchCollection allAlterSymbols = Regex.Matches(name, patternAlterSymbols);
                foreach (Match symbol in allAlterSymbols)
                {
                    if (symbol.Value == "*")
                    {
                        baseDamage *= 2;
                    }
                    else if (symbol.Value == "/")
                    {
                        baseDamage /= 2;
                    }
                }

                var deamon = new Deamon(name, health, baseDamage);
                deamonsBook.Add(deamon);
            }

            deamonsBook = deamonsBook.OrderBy(d => d.Name).ToList();
            string bookContents = string.Join(Environment.NewLine, deamonsBook);
            Console.WriteLine(bookContents);
        }
    }
}
