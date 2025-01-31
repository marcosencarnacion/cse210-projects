using System;

public class Program
{
    static void Main(string[] args)
    {
        // Create a list to store multiple videos.
        List<Video> videos = new List<Video>();

        // Create first video and add comments.
        Video video1 = new Video("C# Basics Tutorial", "Brais Moure", 600);
        video1.AddComment(new Comment("Carlos", "I was thinking about switching technologies, but thanks to this video, I believe I will specialize in ML with C#. Thank you, Mauro, you are amazing!"));
        video1.AddComment(new Comment("Angela", "I love you Brais, everything I look for, you've made a course on! Thank you so much for so much quality content 😍😍"));
        video1.AddComment(new Comment("Jorge", "Another remarkable course... thank you very much."));
        video1.AddComment(new Comment("Israel", "Very interesting, I got a bit confused with the topic of constructors, but I understood it in the end. Thank you."));
        videos.Add(video1);

    }
}