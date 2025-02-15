using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Congratulations! You completed {_shortName} and earned {_points} points!");
        Console.WriteLine($"You now have {_points} points.");
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        string status = _isComplete ? "[X]" : "[ ]";
        return $"{status} {_shortName} ({_description})";
    }
}