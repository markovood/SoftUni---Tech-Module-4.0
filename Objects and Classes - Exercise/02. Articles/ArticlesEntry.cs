using System;

namespace _02._Articles
{
    public class ArticlesEntry
    {
        public static void Main()
        {
            // "{title}, {content}, {author}"
            string[] inputTokens = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string articleTitle = inputTokens[0];
            string articleContent = inputTokens[1];
            string articleAuthor = inputTokens[2];
            Article article = new Article(articleTitle, articleContent, articleAuthor);

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] commandTokens = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries);
                switch (commandTokens[0])
                {
                    case "Edit":
                        string newContent = commandTokens[1];
                        article.Edit(newContent);
                        break;
                    case "ChangeAuthor":
                        string newAuthor = commandTokens[1];
                        article.ChangeAuthor(newAuthor);
                        break;
                    case "Rename":
                        string newTitle = commandTokens[1];
                        article.Rename(newTitle);
                        break;
                }
            }

            // print article
            Console.WriteLine(article);
        }
    }
}
