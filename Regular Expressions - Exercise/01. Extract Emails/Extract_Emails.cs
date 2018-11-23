using System;
using System.Text.RegularExpressions;

namespace _01._Extract_Emails
{
    public class Extract_Emails
    {
        public static void Main()
        {
            string pattern = @"(?<=\s)([A-Za-z0-9][A-Za-z0-9_\.-]+)@([a-z-]+(\.[a-z-]+){1,})";
            string input = Console.ReadLine();

            MatchCollection validEmails = Regex.Matches(input, pattern);
            foreach (Match mail in validEmails)
            {
                Console.WriteLine(mail.Value);
            }
        }
    }
}
