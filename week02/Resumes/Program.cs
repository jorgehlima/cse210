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

        Job job2 = new Job();

        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // Resume obj
        Resume myResume = new Resume();

        // Person's name
        myResume._name = "Allison Rose";
        
        // Adding job objs
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Displays the complete resume
        myResume.Display();
    }
}