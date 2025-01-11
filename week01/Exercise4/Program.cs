using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int input = -1;
        List<int> responses = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (input != 0)
        {
            Console.Write("Enter Number: ");
            input = int.Parse(Console.ReadLine());
            if (input != 0)
            {
                responses.Add(input);
            }
        }

        int total = 0;
        foreach (int response in responses)
        {
            total += response;
        }

        int largest = 0;
        foreach (int response in responses)
        {
            if (response > largest)
            {
                largest = response;
            }
        }

        float average = (float)total / responses.Count;
        Console.WriteLine($"The sum is {total}.");
        Console.WriteLine($"The average is {average}.");
        Console.WriteLine($"The largest number is {largest}.");
    }
}
