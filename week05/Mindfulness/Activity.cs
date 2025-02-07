using System;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage(string startingMessage, string activityDescription)
    {
        Console.WriteLine(startingMessage);
        Console.WriteLine(activityDescription);
        Console.Write("How long, in seconds, would you like for your session? ");
        Console.ReadLine();
    }

    public void DisplayEndingMessage(string endingMessage)
    {
        Console.WriteLine("Well done!");
        Console.WriteLine(endingMessage);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
    }
}