using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    public class Match_Phone_Number
    {
        public static void Main()
        {
            string pattern = @"(\+359)( |-)2\2(\d{3})\2(\d{4})\b";
            string phoneNumbers = Console.ReadLine();

            MatchCollection matches = Regex.Matches(phoneNumbers, pattern);

            var validNumbers = matches
                                .Cast<Match>()
                                .Select(m => m.Value)
                                .ToArray();

            string concatenatedNumbers = string.Join(", ", validNumbers);
            Console.WriteLine(concatenatedNumbers);
        }
    }
}
