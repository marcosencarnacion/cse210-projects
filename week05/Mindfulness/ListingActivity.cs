using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on times in your life when you have shown strenght and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0)
    {
        _count = 0;
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours",
            "Who are people that you have hlped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage("Welcome to the Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        int sessionDuration = int.Parse(Console.ReadLine());
        _duration = sessionDuration;

        Console.WriteLine("Get Ready...");
        ShowSpinner(5);

        Random random = new Random();
        int index = random.Next(_prompts.Count);
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {_prompts[index]} ---");

        Console.WriteLine("You may begin in...");
        ShowCountDown(5);

    }
}