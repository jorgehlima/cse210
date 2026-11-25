using System;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    // Constructor
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }

    // Starting message
    public void DisplayStartingMessage()
    {
    }

    // Ending message
    public void DisplayEndingMessage()
    {
    }

    // Display animated spinner
    public void ShowSpinner(int seconds)
    {
    }

    // Display countdown timer
    public void ShowCountDown(int seconds)
    {
    }

    // Return activity duration
    public int GetDuration()
    {
        return _duration;
    }
}