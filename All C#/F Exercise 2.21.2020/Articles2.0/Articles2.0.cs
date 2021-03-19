using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles
{
    class Articles
    {
        private static object list;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Article> list = new List<Article>();


            for (int i = 0; i < n; i++)
            {
                string[] articleTokens = Console.ReadLine().Split(", ");


                Article newArticle = new Article(articleTokens[0], articleTokens[1], articleTokens[2]);
                list.Add(newArticle);
            }

            string whatToOrderBy = Console.ReadLine();
            List<Article> sortedArticle = new List<Article>();
                //list.OrderBy(a => a.Title).ToList();
           if (whatToOrderBy == "title")
            {
               sortedArticle = list.OrderBy(a => a.Title).ToList();
            }
            else if (whatToOrderBy == "content")
            {
                sortedArticle = list.OrderBy(a => a.Content).ToList();
            }
            else if (whatToOrderBy == "author")
            {
                sortedArticle = list.OrderBy(a => a.Author).ToList();
            }
            Console.WriteLine(string.Join("\n", sortedArticle));

        }
    }



    class Article
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
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }




}
