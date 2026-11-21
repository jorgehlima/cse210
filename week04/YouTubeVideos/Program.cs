
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<Video> videos = new List<Video>();

        Video video1 = new Video(
            "Getting Started with Raspberry Pi",
            "Tech Tutorials",
            600
        );

        Comment comment1 = new Comment(
            "John",
            "Great tutorial for beginners!"
        );

        Comment comment2 = new Comment(
            "Sarah",
            "This helped me set up my Raspberry Pi."
        );

        Comment comment3 = new Comment(
            "Michael",
            "Very clear explanation. Thank you!"
        );

        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        videos.Add(video1);

        Video video2 = new Video(
            "Introduction to C# Programming",
            "Code Academy",
            900
        );

        video2.AddComment(new Comment(
            "Alice",
            "Excellent introduction to C#!"
        ));

        video2.AddComment(new Comment(
            "Robert",
            "The examples were easy to understand."
        ));

        video2.AddComment(new Comment(
            "Emily",
            "Looking forward to more tutorials!"
        ));

        videos.Add(video2);

        Video video3 = new Video(
            "Building Your First Website",
            "Web Development Hub",
            720
        );

        video3.AddComment(new Comment(
            "David",
            "This helped me understand HTML."
        ));

        video3.AddComment(new Comment(
            "Jessica",
            "Great explanation of CSS!"
        ));

        video3.AddComment(new Comment(
            "Daniel",
            "Very useful for beginners."
        ));

        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.Display();
        }

    }
}
