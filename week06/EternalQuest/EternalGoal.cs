using System;

public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
    }
    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You completed {_shortName} and earned {_points} points!");
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        return $"[ ] {_shortName} ({_description})";
    }
}