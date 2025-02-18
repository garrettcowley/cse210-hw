using System;

public class Swimming : Activity
{
    public int Laps { get; private set; }

    public Swimming(DateTime date, int lengthMinutes, int laps)
        : base(date, lengthMinutes)
    {
        Laps = laps;
    }

    public override double GetDistance()
    {
        return (Laps * 50) / 1000.0;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / LengthMinutes) * 60;
    }

    public override double GetPace()
    {
        return LengthMinutes / GetDistance();
    }
}
