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
        video1.AddComment(new Comment("Mark", "I like Pikachu"));

        Video video2 = new Video("Rocks", user2.GetName(), "20:00");
        video2.AddComment(new Comment("Taylor", "This is absolutely a rock."));
        video2.AddComment(new Comment("Brenda", "I don't believe that rocks exists"));
        video2.AddComment(new Comment("Steve", "Very educational"));

        Video video3 = new Video("One Piece", user1.GetName(), "15:00");
        video3.AddComment(new Comment ("Taylor", "Luffy will be the pirates king!"));
        video3.AddComment(new Comment("Mary", "I love Zoro!"));
        video3.AddComment(new Comment("Jake", "Best anime ever"));

        Video video4 = new Video("Space Exploration", user2.GetName(), "12:30");
        video4.AddComment(new Comment("Alice", "Space is amazing!"));
        video4.AddComment(new Comment("Bob", "I want to be an astronaut"));
        video4.AddComment(new Comment("Clara", "Great explanation"));

        channel.AddVideo(video1);
        channel.AddVideo(video2);
        channel.AddVideo(video3);
        channel.AddVideo(video4);

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