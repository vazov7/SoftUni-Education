using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            Article article = new Article(input[0], input[1], input[2]);
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                List<string> inputCommand = Console.ReadLine().Split(": ").ToList();
                string command = inputCommand[0];
                string argument = inputCommand[1];
                switch (command)
                {
                    case "Edit":
                        article.Edit(argument);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(argument);
                            break;
                    case "Rename":
                        article.Rename(argument);
                        break;
                }
            }
                Console.WriteLine(article.ToString());
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

        public string Title{ get; set; }
        public string Content{ get; set; }
        public string  Author{ get; set; }

        public void Edit(string argument)
        {
            Content = argument;
        }
        public void ChangeAuthor(string argument)
        {
            Author = argument;
        }
        public void Rename(string argument)
        {
            Title = argument;
        }
        public override string ToString()
        {
            return $"{ Title} - {Content}: {Author}            "; 
        }
    }
}
