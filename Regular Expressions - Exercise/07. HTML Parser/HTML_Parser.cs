using System;
using System.Text.RegularExpressions;

namespace _07._HTML_Parser
{
    public class HTML_Parser
    {
        public static void Main()
        {
            string patternTitle = @"(?<=<title>)[^<]+";
            string html = Console.ReadLine();

            Match match = Regex.Match(html, patternTitle);
            string title = string.Empty;
            if (match.Success)
            {
                title = match.Value;
            }

            string patternBody = @"(?<=<body>)([^<]+).+(?=<\/body>)";
            match = Regex.Match(html, patternBody);
            string body = string.Empty;
            if (match.Success)
            {
                body = match.Value;
            }

            string patternContent = @"<.+?>";
            string content = string.Join(' ', Regex.Split(body, patternContent));
            content = string.Join(' ', Regex.Split(content, @"\s*\\n\s*"));

            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Content: {content}");
        }
    }
}
