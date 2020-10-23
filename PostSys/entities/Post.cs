using System;
using System.Collections.Generic;
using System.Text;

namespace PostSys.entities
{
    class Post
    {
        public List<Comment> comments { get; set; } = new List<Comment>();
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }
        public void AddComent(string coment)
        {
            Comment comentario = new Comment(coment);
            comments.Add(comentario);
        }

       
    }
}
