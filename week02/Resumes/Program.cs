using System;

class Program
{
    static void Main(string[] args)
    {   // Job object
        Job job1 = new Job();
       
        // Assigning values to Job1
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;

        // Displays company name
        job1.Display();

        Job job2 = new Job();

        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // Displays a sec co name
        job2.Display();

        // Resume obj
        Resume myResume = new Resume();
        // Person's name
        myResume._name = "Allison Rose";
        // Adding job objs
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        Console.WriteLine(myResume._jobs[0]._jobTitle);
    }
}