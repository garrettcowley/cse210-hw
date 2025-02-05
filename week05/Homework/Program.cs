using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment math = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        WritingAssignment writing = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");

        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());
        Console.WriteLine();
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}
