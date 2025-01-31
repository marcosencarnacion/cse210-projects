using System;
using System.Runtime.InteropServices.Marshalling;

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

        // Create second video and add comments.
        Video video2 = new Video("Object-Oriented Programming, Simplified", "Mosh Hamedani", 453);
        video2.AddComment(new Comment("Erik", "Hey, if you you watched the video in double speed, you master oop in even three and a half minutes!"));
        video2.AddComment(new Comment("Sumani", "7 minutes and alot of things in detail. Thanks Mosh."));
        video2.AddComment(new Comment("Geeta", "Hi Mosh. Really your videos are smooth understandable. Thanks"));
        video2.AddComment(new Comment("Stephanie", "You helped me understand OOP in minutes more than my professors did in hours of lecture. Thank you!!"));
        videos.Add(video2);

        // Create third video and add comments.
        Video video3 = new Video("C# classes 📦", "Bro Code", 300);
        video3.AddComment(new Comment("Zoe", "You are a legend, I'm studying it and my teachers explain it as if im already experienced. This is a huge help"));
        video3.AddComment(new Comment("Regie", "Very good clear and succinct presentation. Thanks."));
        video3.AddComment(new Comment("Alex", "Good job you are always explaining very clearly 👏"));
        video3.AddComment(new Comment("Sreenivas", "Awesome explanation ❤ Thank you"));

        // Create fourth video and add comments.
        Video video4 = new Video("Introduction to Classes and Objects", "YK Sugi", 1200);
        video4.AddComment(new Comment("Jonah", "The constructor explanation is gold!"));
        video4.AddComment(new Comment("Clane", "My whole programming for the semester taught powerfully in a very small amount of time in under 20mins. Deserve more subs."));
        video4.AddComment(new Comment("Vibhanshu", "Wow 2021 here still the best video on you tube for classes and object."));
        video4.AddComment(new Comment("Tracer", "I lost my interest in coding 3 years ago & because of you I am getting into this again. ❤️"));

    }
}