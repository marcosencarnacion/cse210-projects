using System;

public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
        
    }
    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }
    public override bool IsComplete()
    {
        throw new NotImplementedException();
    }
    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();
    }
}