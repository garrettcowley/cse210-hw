class LevelSystem
{
    public int Level;
    public int PointsRequired;
    private int _currentPoints;

    public LevelSystem()
    {
        Level = 1;
        PointsRequired = 100;
        _currentPoints = 0;
    }

    public void AddPoints(int points)
    {
        _currentPoints += points;
        CheckLevelUp();
    }

    private void CheckLevelUp()
    {
        while (_currentPoints >= PointsRequired)
        {
            _currentPoints -= PointsRequired;
            Level++;
            PointsRequired = (int)(PointsRequired * 1.5);
            Console.WriteLine($"Congratulations! You leveled up to Level {Level}!");
        }
    }

    public int GetCurrentPoints()
    {
        return _currentPoints;
    }
}