class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"You recorded progress for the goal: {Name} and earned {Points} points.");
    }

    public override string GetProgress()
    {
        return "Eternal";
    }
}