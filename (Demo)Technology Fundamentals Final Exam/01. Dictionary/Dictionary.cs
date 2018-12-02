using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Dictionary
{
    public class Dictionary
    {
        public static void Main()
        {
            string[] wordsAndDescriptions = Console.ReadLine().Split(" | ");
            var dictionary = new Dictionary<string, List<string>>();
            foreach (var wordAndDescription in wordsAndDescriptions)
            {
                string[] tokens = wordAndDescription.Split(": ");
                string word = tokens[0];
                string description = tokens[1];
                if (dictionary.ContainsKey(word))
                {
                    dictionary[word].Add(description);
                }
                else
                {
                    dictionary.Add(word, new List<string>() { description });
                }
            }

            string[] words = Console.ReadLine().Split(" | ");
            foreach (var word in words)
            {
                if (dictionary.ContainsKey(word))
                {
                    var orderedDefinitions = dictionary[word].OrderByDescending(w => w.Length).ToList();
                    Console.WriteLine($"{word}");
                    foreach (var definition in orderedDefinitions)
                    {
                        Console.WriteLine($" -{definition}");
                    }
                }
            }

            string command = Console.ReadLine();
            switch (command)
            {
                case "End":
                    return;
                case "List":
                    // print all of the words, ordered alphabetically, separated by space (" ")
                    List<string> allWords = dictionary.Keys.ToList();
                    allWords.Sort();
                    Console.WriteLine(string.Join(" ", allWords));
                    break;
            }
        }
    }
}
