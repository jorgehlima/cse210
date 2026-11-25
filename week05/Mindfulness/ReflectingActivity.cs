
using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    // Member variables
    private List<string> _prompts;
    private List<string> _questions;

    // Constructor
    public ReflectingActivity() : base(
        "Reflecting",
        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = new List<string>();
        _questions = new List<string>();
    }

    // Run the reflecting activity
    public void Run()
    {
    }

    // Select a random prompt
    private string GetRandomPrompt()
    {
        return "";
    }

    // Select a random question
    private string GetRandomQuestion()
    {
        return "";
    }

    // Display the selected prompt
    private void DisplayPrompt()
    {
    }

    // Display reflection questions
    private void DisplayQuestions()
    {
    }
}
