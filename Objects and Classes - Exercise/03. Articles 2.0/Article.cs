using System;
using System.Collections.Generic;
using System.Text;

namespace _03._Articles_2._0
{
    public class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            string article = $"{Title} - {Content}: {Author}";
            return article;
        }
    }
}
