using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        int grade = int.Parse(Console.ReadLine());
        string letter;

        if (grade > 89)
        {
            letter = "A";
        }
        else if (grade > 79)
        {
            letter = "B";
        }
        else if (grade > 69)
        {
            letter = "C";
        }
        else if (grade > 59)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"You have an {letter}.");
        if (grade < 70)
        {
            Console.WriteLine("If you put in the effort, you can surely pass next time!");
        }
        else
        {
            Console.WriteLine("Great Job! Keep it up!");
        }
    }
}
