using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        User user1 = new User("Ash");
        User user2 = new User("Peter");

        Channel channel = new Channel("My Channel");

        Video video1 = new Video("Pokemon", user1.GetName(), "5:00");
        video1.AddComment(new Comment("John", "Great video"));
        video1.AddComment(new Comment("Lucy", "Bad video"));

        Video video2 = new Video("Rocks", user2.GetName(), "20:00");

        channel.AddVideo(video1);
        channel.AddVideo(video2);

        foreach (Video v in channel.GetVideos())
        {
            Console.WriteLine($"\nTitle: {v.GetTitle()}");
            Console.WriteLine($"Author: {v.GetAuthor()}");
            Console.WriteLine($"Length: {v.GetLength()}");
            Console.WriteLine($"Comments: {v.GetCommentCount()}");

            foreach (Comment c in v.GetComments())
            {
                Console.WriteLine($"- {c.GetAuthor()}: {c.GetText()}");
            }
        }
    }
}