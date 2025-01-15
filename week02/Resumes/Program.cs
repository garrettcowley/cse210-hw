using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Custodian";
        job1._company = "AMC";
        job1._startYear = 1999;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Astronaut";
        job2._company = "NASA";
        job2._startYear = 1969;
        job2._endYear = 1972;

        Resume newResume = new Resume();
        newResume._fullName = "Garrett Cowley";
        newResume._jobs.Add(job1);
        newResume._jobs.Add(job2);
        newResume.Display();

    }
}