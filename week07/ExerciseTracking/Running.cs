using System;

public class Running : Activity
{
    public double Distance { get; private set; }

    public Running(DateTime date, int lengthMinutes, double distance)
        : base(date, lengthMinutes)
    {
        Distance = distance;
    }

    public override double GetDistance()
    {
        return Distance;
    }

    public override double GetSpeed()
    {
        return (Distance / LengthMinutes) * 60;
    }

    public override double GetPace()
    {
        return LengthMinutes / Distance;
    }
}
