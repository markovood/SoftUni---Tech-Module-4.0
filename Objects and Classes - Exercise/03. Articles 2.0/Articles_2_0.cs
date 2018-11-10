using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Articles_2._0
{
    public class Articles_2_0
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();
            for (int i = 0; i < n; i++)
            {
                string[] inputTokens = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string title = inputTokens[0];
                string content = inputTokens[1];
                string author = inputTokens[2];

                var article = new Article(title, content, author);
                articles.Add(article);
            }

            string command = Console.ReadLine();
            switch (command)
            {
                case "title":
                    articles = articles.OrderBy(x => x.Title).ToList();
                    break;
                case "content":
                    articles= articles.OrderBy(x => x.Content).ToList();
                    break;
                case "author":
                    articles = articles.OrderBy(x => x.Author).ToList();
                    break;
            }

            Print(articles);
        }

        private static void Print(List<Article> articles)
        {
            foreach (var article in articles)
            {
                Console.WriteLine(article);
            }
        }
    }
}
