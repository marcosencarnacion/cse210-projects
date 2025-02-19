using System;

public class Swimming : Activity
{
    private int _laps;
    private const double _lapLengthKm = 0.05;

    public Swimming(DateTime date, int duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * _lapLengthKm;
    }

    public override double GetSpeed()
    {
        return GetDistance() / GetDuration() * 60;
    }

    public override double GetPace()
    {
        return GetDuration() / GetDistance();
    }
}