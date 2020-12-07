using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Article> listArticle = new List<Article>();
            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine().Split(", ").ToList();
                Article article = new Article(input[0],input[1], input[2]);
                listArticle.Add(article);
            }
            string command = Console.ReadLine();
            switch (command)
            {
                case "title":
                    listArticle = listArticle.OrderBy(a => a.Title).ToList();
                    break;

                case "content":
                    listArticle = listArticle.OrderBy(a => a.Content).ToList();
                    break;
                case "author":
                    listArticle = listArticle.OrderBy(a => a.Author).ToList();
                    break;
            }
            Console.WriteLine(string.Join(Environment.NewLine, listArticle));

        }
    }
    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

      
        public override string ToString()
        {
            return $"{ Title} - {Content}: {Author}";
        }
    }
}
