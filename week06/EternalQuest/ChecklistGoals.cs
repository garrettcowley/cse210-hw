class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;

    public ChecklistGoal(string name, int points, int targetCount) : base(name, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
    }

    public override void RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
            Console.WriteLine($"You recorded progress for the goal: {Name} and earned {Points} points.");

            if (_currentCount == _targetCount)
            {
                IsComplete = true;
                int bonusPoints = Points * 5;
                Points += bonusPoints;
                Console.WriteLine($"Congratulations! You completed the goal: {Name} and earned a bonus of {bonusPoints} points.");
            }
        }
        else
        {
            Console.WriteLine($"You've already completed the goal: {Name}.");
        }
    }

    public override string GetProgress()
    {
        return $"Completed {_currentCount}/{_targetCount} times";
    }
}