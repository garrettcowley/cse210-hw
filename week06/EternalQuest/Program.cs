using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    private static List<Goal> _goals = new List<Goal>();
    private static LevelSystem _levelSystem = new LevelSystem();
    private static int _totalPoints = 0;

    static void Main(string[] args)
    {
        LoadGoals();

        if (_goals.Count == 0)
        {
            AddDefaultGoals();
        }

        while (true)
        {
            Console.WriteLine("\nGoal Tracker Menu:");
            Console.WriteLine("1. View Goals");
            Console.WriteLine("2. Create New Goal");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. View Score and Level");
            Console.WriteLine("5. Save and Exit");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                DisplayGoals();
            }
            else if (choice == 2)
            {
                CreateGoal();
            }
            else if (choice == 3)
            {
                RecordEvent();
            }
            else if (choice == 4)
            {
                DisplayScoreAndLevel();
            }
            else if (choice == 5)
            {
                SaveGoals();
                return;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }

    static void AddDefaultGoals()
    {
        _goals.Add(new SimpleGoal("Take a walk", 100));
        _goals.Add(new EternalGoal("Drink water", 50));
        _goals.Add(new ChecklistGoal("Go to sleep on time", 200, 7));
        Console.WriteLine("Default goals added!");
    }

    static void DisplayGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available.");
            return;
        }

        Console.WriteLine("\nYour Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i]}");
        }
    }

    static void CreateGoal()
    {
        Console.WriteLine("\nChoose Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        int choice = int.Parse(Console.ReadLine());

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            _goals.Add(new SimpleGoal(name, points));
        }
        else if (choice == 2)
        {
            _goals.Add(new EternalGoal(name, points));
        }
        else if (choice == 3)
        {
            Console.Write("Enter target count: ");
            int targetCount = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, points, targetCount));
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }

        Console.WriteLine("Goal created successfully!");
    }

    static void RecordEvent()
    {
        DisplayGoals();
        if (_goals.Count == 0) return;

        Console.Write("Enter the goal number to record: ");
        int goalNumber = int.Parse(Console.ReadLine()) - 1;

        if (goalNumber >= 0 && goalNumber < _goals.Count)
        {
            _goals[goalNumber].RecordEvent();
            _totalPoints += _goals[goalNumber].GetPoints();
            _levelSystem.AddPoints(_goals[goalNumber].GetPoints());
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    static void DisplayScoreAndLevel()
    {
        Console.WriteLine($"\nTotal Points: {_totalPoints}");
        Console.WriteLine($"Current Level: {_levelSystem.Level}");
    }

    static void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(_totalPoints);
            writer.WriteLine(_levelSystem.Level);
            writer.WriteLine(_levelSystem.PointsRequired);
            writer.WriteLine(_goals.Count);

            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetType().Name);
                writer.WriteLine(goal.Name);
                writer.WriteLine(goal.GetPoints());

                if (goal is ChecklistGoal checklistGoal)
                {
                    writer.WriteLine(checklistGoal.GetProgress());
                }
            }
        }

        Console.WriteLine("Goals saved successfully!");
    }

    static void LoadGoals()
    {
        if (File.Exists("goals.txt"))
        {
            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                _totalPoints = int.Parse(reader.ReadLine());
                _levelSystem = new LevelSystem
                {
                    Level = int.Parse(reader.ReadLine()),
                    PointsRequired = int.Parse(reader.ReadLine())
                };

                int goalCount = int.Parse(reader.ReadLine());

                for (int i = 0; i < goalCount; i++)
                {
                    string goalType = reader.ReadLine();
                    string name = reader.ReadLine();
                    int points = int.Parse(reader.ReadLine());

                    if (goalType == nameof(SimpleGoal))
                    {
                        _goals.Add(new SimpleGoal(name, points));
                    }
                    else if (goalType == nameof(EternalGoal))
                    {
                        _goals.Add(new EternalGoal(name, points));
                    }
                    else if (goalType == nameof(ChecklistGoal))
                    {
                        string progress = reader.ReadLine();
                        string[] parts = progress.Split('/');
                        int currentCount = int.Parse(parts[0].Split(' ')[1]);
                        int targetCount = int.Parse(parts[1].Split(' ')[0]);
                        var checklistGoal = new ChecklistGoal(name, points, targetCount);
                        for (int j = 0; j < currentCount; j++)
                        {
                            checklistGoal.RecordEvent();
                        }
                        _goals.Add(checklistGoal);
                    }
                }
            }

            Console.WriteLine("Goals loaded successfully!");
        }
    }
}