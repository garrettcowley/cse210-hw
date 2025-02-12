class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent()
    {
        if (!IsComplete)
        {
            IsComplete = true;
            Console.WriteLine($"Congratulations! You completed the goal: {Name} and earned {Points} points.");
        }
        else
        {
            Console.WriteLine($"You've already completed the goal: {Name}.");
        }
    }

    public override string GetProgress()
    {
        return IsComplete ? "Completed" : "Not Completed";
    }
}