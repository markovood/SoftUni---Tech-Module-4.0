using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._Post_Office
{
    public class Post_Office
    {
        public static void Main()
        {
            string line = Console.ReadLine();
            string[] parts = line.Split('|', StringSplitOptions.RemoveEmptyEntries);

            // first part
            var match = Regex.Match(parts[0], @"(?<=\$)[A-Z]+(?=\$)|(?<=#)[A-Z]+(?=#)|(?<=%)[A-Z]+(?=%)|(?<=\*)[A-Z]+(?=\*)|(?<=&)[A-Z]+(?=&)");
            string capitalLetters = match.Value;

            // second part
            var lettersAndRemainWordLength = new Dictionary<char, int>();
            var matches = Regex.Matches(parts[1], @"[6-9][0-9]:[0-9][0-9]");
            var uniqueMatches = matches
                                .Select(m => m.Value)
                                .Distinct();
            foreach (var uniqueMatch in uniqueMatches)
            {
                string[] tokens = uniqueMatch.Split(':');
                char letter = (char)int.Parse(tokens[0]);
                int remainWordLength = int.Parse(tokens[1]);

                lettersAndRemainWordLength.Add(letter, remainWordLength);
            }

            // third part
            string[] words = parts[2].Split(' ');
            foreach (var letter in capitalLetters)
            {
                int length = lettersAndRemainWordLength[letter] + 1;
                var validWords = words.Where(w => w.StartsWith(letter) && w.Length == length);
                Console.WriteLine(string.Join(Environment.NewLine, validWords));
            }
        }
    }
}
