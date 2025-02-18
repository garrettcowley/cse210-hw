using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        var activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 3), 30, 4.8),
            new Cycling(new DateTime(2022, 11, 4), 45, 20.0),
            new Swimming(new DateTime(2022, 11, 5), 60, 40),
            new Running(new DateTime(2022, 11, 6), 25, 5.0),
            new Cycling(new DateTime(2022, 11, 7), 50, 22.0),
            new Swimming(new DateTime(2022, 11, 8), 55, 35),
            new Running(new DateTime(2022, 11, 9), 35, 6.0),
            new Cycling(new DateTime(2022, 11, 10), 40, 18.5),
            new Swimming(new DateTime(2022, 11, 11), 65, 50),
            new Running(new DateTime(2022, 11, 12), 20, 3.5)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
