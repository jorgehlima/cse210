
using System;

public class BreathingActivity : Activity
{
    // Constructor
    public BreathingActivity() : base(
        "Breathing",
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    // Run breathing activity
    public void Run()
    {
        // Display inherited starting message
        DisplayStartingMessage();

        // Calculate activity ending time
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            // Calculate remaining time
            int remainingSeconds = (int)Math.Ceiling(
                (endTime - DateTime.Now).TotalSeconds);

            if (remainingSeconds <= 0)
            {
                break;
            }

            // Breathe in
            Console.WriteLine();
            Console.Write("Breathe in... ");
            ShowCountDown(Math.Min(4, remainingSeconds));

            // Recalculate remaining time
            remainingSeconds = (int)Math.Ceiling(
                (endTime - DateTime.Now).TotalSeconds);

            if (remainingSeconds <= 0)
            {
                break;
            }

            // Breathe out
            Console.WriteLine();
            Console.Write("Breathe out... ");
            ShowCountDown(Math.Min(6, remainingSeconds));
        }

        // Display inherited ending message
        DisplayEndingMessage();
    }
}
