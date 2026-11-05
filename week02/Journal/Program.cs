using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        string choice = "";

        // Prompts list
        List<string> prompts = new List<string>
        {
            "What was the best part of your day?",
            "What positive thing happened today?",
            "What challenges did you face today?",
            "What did you learn today?",
            "What are you grateful for today?"
        };

        // Random num generator
        Random random = new Random();

        Console.WriteLine("Welcome to the Journal Program!");

        // While loop
        while (choice != "5")
        {
            Console.WriteLine();
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            choice = Console.ReadLine() ?? "";

            if (choice == "1")
            {
                int index = random.Next(prompts.Count);
                string prompt = prompts[index];

                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine() ?? "";

                DateTime currentDate = DateTime.Now;
                string date = currentDate.ToShortDateString();

                Entry newEntry = new Entry();
                newEntry._date = date;
                newEntry._promptText = prompt;
                newEntry._entryText = response;

                myJournal.AddEntry(newEntry);

                Console.WriteLine("Journal entry added successfully!");
            }

            // Display option
            else if (choice == "2")
            {
                Console.WriteLine();
                Console.WriteLine("Your Journal Entries:");
                myJournal.DisplayAll();
            }

            // EXCEEDING REQUIREMENTS
            // I added the exception below that handles load option 3.
            // If the user enters a wrong file name the program return an error message.
            // Load saved journal - error handling during file load.
            else if (choice == "3")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine() ?? "";

                try
                {
                    myJournal.LoadFromFile(filename);
                    Console.WriteLine("Journal loaded successfully!");
                }
                catch (System.IO.FileNotFoundException)
                {
                    Console.WriteLine("Error: The file was not found. Please check the filename.");
                }
            }

            // Save option
            else if (choice == "4")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine() ?? "";

                myJournal.SaveToFile(filename);

                Console.WriteLine("Journal saved successfully!");
            }
        }
    }
}