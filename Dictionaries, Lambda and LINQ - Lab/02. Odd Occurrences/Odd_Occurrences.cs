using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    public class Odd_Occurrences
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().Split(' ');

            var wordsAndCount = new Dictionary<string, int>();
            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i].ToLower();
                if (wordsAndCount.ContainsKey(currentWord))
                {
                    wordsAndCount[currentWord]++;
                }
                else
                {
                    wordsAndCount.Add(currentWord, 1);
                }
            }

            var filtered = wordsAndCount.Where(w => w.Value % 2 != 0).ToList();
            string result = string.Empty;
            foreach (var item in filtered)
            {
                result += item.Key + " ";
            }

            Console.WriteLine(result.TrimEnd());
        }
    }
}
