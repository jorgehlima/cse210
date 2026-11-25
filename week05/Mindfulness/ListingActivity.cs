
using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    // Member variables
    private int _count;
    private List<string> _prompts;

    // Constructor
    public ListingActivity() : base(
        "Listing",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _count = 0;
        _prompts = new List<string>();
    }

    // Run the listing activity
    public void Run()
    {
    }

    // Select a random prompt
    private string GetRandomPrompt()
    {
        return "";
    }

    // Collect responses from the user
    private List<string> GetListFromUser()
    {
        return new List<string>();
    }
}
