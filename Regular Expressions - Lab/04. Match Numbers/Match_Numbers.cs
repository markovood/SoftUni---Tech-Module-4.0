using System;
using System.Text.RegularExpressions;

namespace _04._Match_Numbers
{
    public class Match_Numbers
    {
        public static void Main()
        {
            string pattern = @"(^|(?<=\s))-?[0-9.]+($|(?=\s))";
            string input = Console.ReadLine();

            MatchCollection intsAndDoubles = Regex.Matches(input, pattern);

            foreach (Match number in intsAndDoubles)
            {
                Console.Write(number.Value + " ");
            }
        }
    }
}
