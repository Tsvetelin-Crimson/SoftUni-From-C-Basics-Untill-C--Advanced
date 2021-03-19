using System;

namespace Articles
{
    class Articles
    {
        static void Main(string[] args)
        {
            string[] inputArticle = Console.ReadLine().Split(", ");
            Article art = new Article(inputArticle[0], inputArticle[1], inputArticle[2]);
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commandstr = Console.ReadLine().Split(": ");
                string command = commandstr[0],
                    change = commandstr[1];

                if (command == "Edit")
                {
                    art.Edit(change);
                }
                else if (command == "ChangeAuthor")
                {
                    art.ChangeAuthor(change);
                }
                else if (command == "Rename")
                {
                    art.Rename(change);
                }
            }

            Console.WriteLine(art);


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


        public void Edit(string content)
        {
            this.Content = content;
        }
        public void ChangeAuthor(string author)
        {
            this.Author = author;
        }

        public void Rename(string title)
        {
            this.Title = title;
        }
        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }




}
