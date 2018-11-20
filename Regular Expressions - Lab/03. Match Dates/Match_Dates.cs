using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    public class Match_Dates
    {
        public static void Main()
        {
            string pattern = @"\b([0-3][0-9])(\.|-|\/)([A-Z][a-z]{2})\2(\d{4})\b";
            string dates = Console.ReadLine();

            var validDates = Regex.Matches(dates, pattern);
            foreach (Match date in validDates)
            {
                // group day = 1 
                var day = date.Groups[1];
                Console.Write($"Day: {day}, ");

                // group month = 3 (group 2 is the separator)
                var month = date.Groups[3];
                Console.Write($"Month: {month}, ");

                // group year = 4
                var year = date.Groups[4];
                Console.WriteLine($"Year: {year}");
            }
        }
    }
}
