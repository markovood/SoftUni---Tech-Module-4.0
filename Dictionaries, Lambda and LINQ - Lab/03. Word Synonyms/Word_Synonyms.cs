using System;
using System.Collections.Generic;

namespace _03._Word_Synonyms
{
    public class Word_Synonyms
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var wordsAndSynonims = new Dictionary<string, List<string>>();
            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonim = Console.ReadLine();

                if (wordsAndSynonims.ContainsKey(word))
                {
                    wordsAndSynonims[word].Add(synonim);
                }
                else
                {
                    wordsAndSynonims.Add(word, new List<string>() { synonim });
                }
            }

            foreach (var item in wordsAndSynonims)
            {
                Console.Write($"{item.Key} - {string.Join(", ", item.Value)}");
                Console.WriteLine();
            }
        }
    }
}
