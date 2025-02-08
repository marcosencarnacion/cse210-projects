using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strenght and resilience. This will help you recognize the power you have and how you an use it in other aspects of your life.", 0)
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        return _questions[random.Next(_questions.Count)];
    }


    public void Run()
    {
        DisplayStartingMessage("Welcome to the Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strenght and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

        int sessionDuration = int.Parse(Console.ReadLine());
        _duration = sessionDuration;

        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);

        string prompt = GetRandomPrompt();
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine($"--- {prompt} ---");

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now, ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();


        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(sessionDuration);



        while (DateTime.Now < endTime)
        {
            string question = GetRandomQuestion();
            Console.Write($"{question} ");
            ShowSpinner(5);
            Console.WriteLine();
        }

        Console.WriteLine();
        DisplayEndingMessage($"You have completed another {sessionDuration} seconds of the Reflecting Activity.");
        ShowSpinner(5);



    }


}