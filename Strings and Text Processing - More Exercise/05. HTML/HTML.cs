using System;

namespace _05._HTML
{
    public class HTML
    {
        public static void Main()
        {
            string titleContent = Console.ReadLine();
            string articleContent = Console.ReadLine();

            Console.WriteLine($"<h1>{Environment.NewLine}\t{titleContent}{Environment.NewLine}</h1>");
            Console.WriteLine($"<article>{Environment.NewLine}\t{articleContent}{Environment.NewLine}</article>");
            while (true)
            {
                string commentContent = Console.ReadLine();
                if (commentContent == "end of comments")
                {
                    break;
                }
                
                Console.WriteLine($"<div>{Environment.NewLine}\t{commentContent}{Environment.NewLine}</div>");
            }

        }
    }
}
