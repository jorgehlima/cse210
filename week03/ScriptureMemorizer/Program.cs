
using System;

/*
 *    EXCEEDING REQUIREMENTS:
 *
 * 1. The program picks random words only from a list of 
 *    words that are not already hidden. This ensures that every 
 *    new word entered disappears Enter is pressed.
 *
 * 2. The program will keep punctuation of hidden words. Underscores 
 *    will replace letter only, permitting users to distinguish the 
 *    structure of the sentence while memorizing it.
 */

class Program
{
    static void Main(string[] args)
    {
        // Create scripture reference
        Reference reference = new Reference("Proverbs", 3, 5, 6);

        // Create scripture text
        string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding.";


        // Create scripture object
        Scripture scripture = new Scripture(reference, text);

        // Display complete scripture
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());


        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine();
            Console.Write("Press Enter to continue or type 'quit' to finish: ");

            string input = Console.ReadLine() ?? "";

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);

            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
        }
    }
}



