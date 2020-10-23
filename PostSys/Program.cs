using PostSys.entities;
using System;
using System.Net.Mime;

namespace PostSys
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2018, 06, 21, 13, 05, 44);
            string title = "Traveling to New Zealand";
            string content = "I'm going to visit this wonderful country!";
            int likes = 12;

            Post post1 = new Post(date, title, content, likes);
            post1.AddComent("Have a nice trip");
            post1.AddComent("Wow That's awsome!");

            Console.WriteLine(post1.Title);
            Console.WriteLine(post1.Likes + " Likes - " + post1.Moment);
            Console.WriteLine(post1.Content);
            Console.WriteLine("Comments:");
            foreach (Comment x in post1.comments)
            {
                Console.WriteLine(x.Text);
            }
            Console.WriteLine("");

            date = new DateTime(2018, 08, 28, 23, 14, 19);
            title = "Good night guys";
            content = "See you tomorrow";
            likes = 5;
            Post post2 = new Post(date, title, content, likes);
            post2.AddComent("Good night");
            post2.AddComent("May the force be with you");
            Console.WriteLine(post2.Title);
            Console.WriteLine(post2.Likes + " Likes - " + post2.Moment);
            Console.WriteLine(post2.Content);
            Console.WriteLine("Comments:");
            foreach(Comment x in post2.comments)
            {
                Console.WriteLine(x.Text);
            }


        }
    }
}
