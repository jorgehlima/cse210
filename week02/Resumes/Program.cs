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
        Console.WriteLine(job1._company);

        Job job2 = new Job();

        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // Displays a sec co name
        Console.WriteLine(job2._company);

    }
}