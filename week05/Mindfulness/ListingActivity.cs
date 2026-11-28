
using System;
using System.Threading;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    // Member variables
    private int _count;
    private List<string> _prompts;
    private List<string> _availablePrompts;

    // Constructor
    public ListingActivity() : base(
        "Listing",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _count = 0;

        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        _availablePrompts = new List<string>(_prompts);
    }

    // Run the listing activity
    public void Run()
    {
        // Display the inherited starting message
        DisplayStartingMessage();

        // Display a random listing prompt
        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();

        string prompt = GetRandomPrompt();

        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();

        // Give the user time to prepare
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        Console.WriteLine();

        // Collect responses from the user
        List<string> responses = GetListFromUser();

        // Count the number of responses
        _count = responses.Count;

        // Display the total number of responses
        Console.WriteLine();
        Console.WriteLine($"You listed {_count} items!");

        // Display the inherited ending message
        DisplayEndingMessage();
    }

    // Select a random prompt
    private string GetRandomPrompt()
    {
        if (_availablePrompts.Count == 0)
        {
            _availablePrompts = new List<string>(_prompts);
        }

        Random random = new Random();

        int index = random.Next(_availablePrompts.Count);

        string prompt = _availablePrompts[index];

        _availablePrompts.RemoveAt(index);

        return prompt;
    }

    // Collect responses from the user
    private List<string> GetListFromUser()
    {
        // Create a list to store user responses
        List<string> responses = new List<string>();

        // Calculate the activity ending time
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");

            string response = "";

            // Collect keyboard input until Enter or time expires
            while (DateTime.Now < endTime)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);

                    if (key.Key == ConsoleKey.Enter)
                    {
                        Console.WriteLine();

                        if (!string.IsNullOrWhiteSpace(response))
                        {
                            responses.Add(response);
                        }

                        break;
                    }
                    else if (key.Key == ConsoleKey.Backspace)
                    {
                        if (response.Length > 0)
                        {
                            response = response.Substring(
                                0, response.Length - 1);

                            Console.Write("\b \b");
                        }
                    }
                    else if (!char.IsControl(key.KeyChar))
                    {
                        response += key.KeyChar;
                        Console.Write(key.KeyChar);
                    }
                }
                else
                {
                    Thread.Sleep(50);
                }
            }
        }

        Console.WriteLine();

        return responses;
    }
}
