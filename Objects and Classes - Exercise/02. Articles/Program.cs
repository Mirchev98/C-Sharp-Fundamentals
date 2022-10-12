using System;
using System.Linq;

namespace _02._Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] filler = Console.ReadLine().Split(", ");
            int numberOfCommands = int.Parse(Console.ReadLine());

            
            Article article = new Article
            {
                Title = filler[0],
                Content = filler[1],
                Author = filler[2]
            };
            
            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] tokens = Console.ReadLine().Split(": ");

                if (tokens[0] == "Edit")
                {
                    article.Content = tokens[1];
                }
                else if (tokens[0] == "ChangeAuthor")
                {
                    article.Author = tokens[1];
                }
                else if (tokens[0] == "Rename")
                {
                    article.Title = tokens[1];
                }
            }
            Console.WriteLine(article);
        }
    }

    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public override string ToString() => $"{Title} - {Content}: {Author}";
    }
}
