using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 0)
    {
    }

    public void Run()
    {
        DisplayStartingMessage("Welcome to the Breathing Activity.", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

        int sessionDuration = int.Parse(Console.ReadLine());

        _duration = sessionDuration;
    }


}