using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    // Member variables
    private List<string> _prompts;
    private List<string> _questions;
    private List<string> _availableQuestions;
    private List<string> _availablePrompts;

    // Constructor
    public ReflectingActivity() : base(
        "Reflecting",
        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        // Initialize the reflection prompts
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        // Initialize the reflection questions
        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        // Create a copy of the original questions
        _availableQuestions = new List<string>(_questions);

        // Create a copy of the original prompts
        _availablePrompts = new List<string>(_prompts);
    }

    // Run the reflecting activity
    public void Run()
    {
        // Display the inherited starting message
        DisplayStartingMessage();

        // Display a random reflection prompt
        DisplayPrompt();

        // Display reflection questions
        DisplayQuestions();

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

    // Select a random question
    private string GetRandomQuestion()
        {
        if (_availableQuestions.Count == 0)
        {
            _availableQuestions = new List<string>(_questions);
        }

        Random random = new Random();

        int index = random.Next(_availableQuestions.Count);

        string question = _availableQuestions[index];

        _availableQuestions.RemoveAt(index);

        return question;
        }

    // Display the selected prompt
    private void DisplayPrompt()
    {
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();

        // Retrieve and display a random prompt
        string prompt = GetRandomPrompt();

        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();

        Console.WriteLine("When you have something in mind, press Enter to continue.");

        Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");

        Console.Write("You may begin in: ");
        ShowCountDown(5);

        Console.Clear();
    }

    // Display reflection questions
    private void DisplayQuestions()
    {
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            string question = GetRandomQuestion();

            Console.Write($"> {question} ");

            int remainingSeconds = (int)Math.Ceiling(
                (endTime - DateTime.Now).TotalSeconds);

            if (remainingSeconds <= 0)
            {
                break;
            }

            // Display spinner while the user reflects
            ShowSpinner(Math.Min(10, remainingSeconds));

            Console.WriteLine();
        }
    }
}