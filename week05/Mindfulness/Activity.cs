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

    public void DisplayStartingMessage(string startingMessage, string activityPurpose)
    {
        Console.WriteLine(startingMessage);
        Console.WriteLine(activityPurpose);
    }
}