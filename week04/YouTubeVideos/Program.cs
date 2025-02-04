using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        Video video1 = new Video("Intro to C#", "Harry", 600);
        Video video2 = new Video("Abstraction", "Ron", 1200);
        Video video3 = new Video("Encapsulation", "Hermione", 900);

        
        video1.AddComment(new Comment("frodo123", "Great tutorial!"));
        video1.AddComment(new Comment("legolas1999", "Very helpful, thanks!"));
        video1.AddComment(new Comment("youshallnotpass28", "I learned a lot from this."));

      
        video2.AddComment(new Comment("antman33", "Now I know how to define abstraction to my kids."));
        video2.AddComment(new Comment("starlord11", "I finally understood something"));
        video2.AddComment(new Comment("gamora22", "I feel like escaping and sharing this with the world"));

       
        video3.AddComment(new Comment("ninja12", "Encapsulation is a powerful concept."));
        video3.AddComment(new Comment("kungfu89", "Could you make a video on abstraction?"));
        video3.AddComment(new Comment("cobrakai4", "Loved the examples!"));

        
        List<Video> videos = new List<Video> { video1, video2, video3 };

        
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");
            foreach (var comment in video.GetAllComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.CommentText}");
            }
            Console.WriteLine(); 
        }
    }
}