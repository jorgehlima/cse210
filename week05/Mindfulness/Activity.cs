using System;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    private int _completedSessions;

    // Constructor
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
        _completedSessions = 0;
    }

    // Starting message
    public void DisplayStartingMessage()
    {
        Console.Clear();

        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();

        // Ask for the activity duration
        Console.Write("How long, in seconds, would you like for your session? ");

        // Validate the user's input
        while (!int.TryParse(Console.ReadLine(), out _duration) || _duration <= 0)
        {
            Console.Write("Please enter a positive number of seconds: ");
        }

        Console.Clear();

        Console.WriteLine("Get ready...");
        ShowSpinner(5);
    }

    // Ending message
    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");

        ShowSpinner(3);

        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");

        ShowSpinner(5);

        _completedSessions++;
    }

    // Display animated spinner
    public void ShowSpinner(int seconds)
    {
        string[] animationStrings = { "|", "/", "-", "\\" };

        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        int index = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(animationStrings[index]);

            Thread.Sleep(250);

            Console.Write("\b \b");

            index++;

            if (index >= animationStrings.Length)
            {
                index = 0;
            }
        }
    }

    // Display countdown timer
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);

            Thread.Sleep(1000);

            // Erase the displayed number
            for (int j = 0; j < i.ToString().Length; j++)
            {
                Console.Write("\b \b");
            }
        }
    }

    // Return activity duration
    public int GetDuration()
    {
        return _duration;
    }

    public int GetCompletedSessions()
    {
        return _completedSessions;
    }
}