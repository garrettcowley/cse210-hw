using System;

public abstract class Activity
{
    public DateTime Date { get; private set; }
    public int LengthMinutes { get; private set; }

    public Activity(DateTime date, int lengthMinutes)
    {
        Date = date;
        LengthMinutes = lengthMinutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} {this.GetType().Name} ({LengthMinutes} min): " +
               $"Distance: {GetDistance():0.0} km, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
    }
}
