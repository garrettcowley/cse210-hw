using System;

abstract class Goal
{
    public string Name;
    protected int Points;
    protected bool IsComplete;
    protected Goal(string name, int points)
    {
        Name = name;
        Points = points;
        IsComplete = false;
    }

    public abstract void RecordEvent();
    public abstract string GetProgress();

    public override string ToString()
    {
        return $"[{(IsComplete ? "X" : " ")}] {Name} - {GetProgress()}";
    }

    public int GetPoints()
    {
        return Points;
    }

    public bool CheckComplete()
    {
        return IsComplete;
    }
}