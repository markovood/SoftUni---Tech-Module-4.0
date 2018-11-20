using System;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    public class Match_Full_Name
    {
        public static void Main()
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            string names = Console.ReadLine();
            MatchCollection matches = Regex.Matches(names, pattern);
            foreach (Match match in matches)
            {
                Console.Write(match + " ");
            }
        }
    }
}
