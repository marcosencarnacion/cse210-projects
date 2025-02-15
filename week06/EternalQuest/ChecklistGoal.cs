using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string shortName, string description, int points, int target, int bonus) : base(shortName, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;

        if (IsComplete())
        {
            Console.WriteLine($"Congratulations! You have earned {_points + _bonus} points!");

        }
        else
        {
            Console.WriteLine($"Good Job! You made progress on '{_shortName}'. ({_amountCompleted}/{_target} Completed)");
        }

    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"{_shortName} ({_description} - Completed {_amountCompleted}/{_target})";
    }

    public override string GetStringRepresentation()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {_shortName} ({_description}) -- Completed {_amountCompleted}/{_target}";
    }

    public override string GetSaveString()
    {
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_target}|{_bonus}|{_amountCompleted}";
    }

    internal void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }
}