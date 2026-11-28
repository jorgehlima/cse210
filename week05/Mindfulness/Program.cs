/* Exceeding Requirements
* 1. Reflection Questions Non-repeating
*    Running the program it will randomly select reflection questions
*    without repetition until all of the questions have been used.
*
* 2. Reflection prompts non-repeating
*    Running the program it will return all four reflection prompts
*    before reloading the available prompts
*
* 3. Listing prompts non-repeating
*    Running the program will return all five listing prompts
*    Before reloading the available prompts
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create the activity objects
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        ListingActivity listingActivity = new ListingActivity();

        string choice = "";

        // Display the menu until the user chooses to quit
        while (choice != "4")
        {
            Console.Clear();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = Console.ReadLine() ?? "";

            if (choice == "1")
            {
                breathingActivity.Run();
            }
            else if (choice == "2")
            {
                reflectingActivity.Run();
            }
            else if (choice == "3")
            {
                listingActivity.Run();
            }
            else if (choice == "4")
            {
                // Retrieve the completed session counts
                int breathingCount = breathingActivity.GetCompletedSessions();
                int reflectingCount = reflectingActivity.GetCompletedSessions();
                int listingCount = listingActivity.GetCompletedSessions();

                // Calculate the total number of completed activities
                int totalCount = breathingCount + reflectingCount + listingCount;

                // Display activity statistics
                Console.Clear();

                Console.WriteLine("Mindfulness Activity Statistics");
                Console.WriteLine("--------------------------------");

                Console.WriteLine($"Breathing activities completed:  {breathingCount}");
                Console.WriteLine($"Reflecting activities completed: {reflectingCount}");
                Console.WriteLine($"Listing activities completed:    {listingCount}");

                Console.WriteLine("--------------------------------");
                Console.WriteLine($"Total activities completed:      {totalCount}");

                Console.WriteLine();
                Console.WriteLine("Thank you for using the Mindfulness Program!");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Invalid choice. Please select an option from 1 to 4.");
                Console.WriteLine("Press Enter to continue.");
                Console.ReadLine();
            }
        }
    }
}