
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        // Create a list to store all videos
        List<Video> videos = new List<Video>();

        // Create the first video
        Video video1 = new Video(
            "Getting Started with Raspberry Pi",
            "Tech Tutorials",
            600
        );

        // Create three comments
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

        // Add comments to the video
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        // Add the first video to the list
        videos.Add(video1);


        // Create the second video
        Video video2 = new Video(
            "Introduction to C# Programming",
            "Code Academy",
            900
        );

        // Add comments to the second video
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

        // Add the second video to the list
        videos.Add(video2);

        // Create the third video
        Video video3 = new Video(
            "Building Your First Website",
            "Web Development Hub",
            720
        );

        // Add comments to the third video
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

        // Add the third video to the list
        videos.Add(video3);


        // Display all videos and their comments
        foreach (Video video in videos)
        {
            video.Display();
        }

    }
}
