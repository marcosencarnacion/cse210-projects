using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strenght and resilience. This will help you recognize the power you have and how you an use it in other aspects of your life.", 0)
    {

    }

    public void Run()
    {
        DisplayStartingMessage("Welcome to the Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strenght and resilience. This will help you recognize the power you have and how you an use it in other aspects of your life");

        int sessionDuration = int.Parse(Console.ReadLine());
        _duration = sessionDuration;

        Console.Clear();

    }


}