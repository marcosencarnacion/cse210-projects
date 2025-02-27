using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        return "";
    }

    public abstract string GetStringRepresentation();

    public virtual int GetPoints()
    {
        return _points;
    }

    public abstract string GetSaveString();

    public string GetShortName()
    {
        return _shortName;
    }

}