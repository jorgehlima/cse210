
using System;

class Program
{
    static void Main(string[] args)
    {
        // This is the Assignment object
        Assignment assignment1 = new Assignment("Samuel Bennett", "Multiplication");

        // This is the assignment summary
        Console.WriteLine(assignment1.GetSummary());

        // This creates the MathAssignment obj
        MathAssignment mathAssignment1 = new MathAssignment(
            "Roberto Rodriguez",
            "Fractions",
            "7.3",
            "8-19"
        );

        Console.WriteLine(mathAssignment1.GetSummary());
        Console.WriteLine(mathAssignment1.GetHomeworkList());

        // Create a WritingAssignment object
        WritingAssignment writingAssignment1 = new WritingAssignment(
            "Mary Waters",
            "European History",
            "The Causes of World War II"
        );

        // Test the inherited and child methods
        Console.WriteLine(writingAssignment1.GetSummary());
        Console.WriteLine(writingAssignment1.GetWritingInformation());
    }
}
