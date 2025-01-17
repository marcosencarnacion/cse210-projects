using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new(); // Create a new journal object
        PromptGenerator promptGenerator = new(); // Createa new prompt generator object

        DisplayWelcomeMessage(); // Display the welcome message when the program starts

        bool continueRunning = true; // Flag to control the menu loop.

        while (continueRunning)
        {
            DisplayMenu(); // Show the menu with options for the user
            int option;

            // Try to parse the user's input ot an integer
            if (int.TryParse(Console.ReadLine(), out option))
            {
                continueRunning = HandleMenuOption(option, journal, promptGenerator); // Handle the selected option
            }
            else
            {
                Console.WriteLine("Invalid input. Please choose a valid option");
            }
        }

        Console.WriteLine("Goodbye!"); // Display a goodbye essage when quitting
    }

    // Method to display the welcome message whenthe program starts
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Journal Program!");
    }

    // Method to display the menu with available choices
    static void DisplayMenu()
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write in my journal");
        Console.WriteLine("2. Display my journal");
        Console.WriteLine("3. Save journal to file");
        Console.WriteLine("4. Load journal to file");
        Console.WriteLine("5. Quit");
        Console.WriteLine("What would you like to do? ");
    }

    // Method to hande the user's menu choice
    static bool HandleMenuOption(int option, Journal journal, PromptGenerator promptGenerator)
    {
        switch (option)
        {
            case 1:
                // User wants to write in the journal
                string randomPrompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(randomPrompt); // Display the prompt
                string userEntry = Console.ReadLine(); // Get the user's entry
                Entry entry = new Entry(DateTime.Now.ToShortDateString(), randomPrompt, userEntry); // Create a new entry

                journal.AddEntry(entry); // Add the entry to the journal
                break;

            case 2:
                // User wants to display all entries
                journal.DisplayAll(); // Call the DisplayAll method
                break;

            case 3:
                // User wants to save the journal to a file
                Console.Write("Enter the filename to save the journalL ");
                string saveFileName = Console.ReadLine(); // Get the filename from user
                journal.SaveToFile(saveFileName); // Call the SaveToFile method
                Console.WriteLine("Journal saved!");
                break;

            case 4:
                // User wants to load the journal from a file
                Console.Write("Enter the filename to load the jorunal: ");
                string loadFileName = Console.ReadLine(); // Get the filename
                journal.LoadFromFile(loadFileName); // Call the LoadFromFile method
                Console.WriteLine("Journal loaded!");
                break;

            case 5:
                // User wants to quit the program
                return false; // Return false to stop the loop and quit the program

            default:
                Console.WriteLine("Invalid option. Please try again.");
                break;
        }

        return true; // Continue running if the user hasn't chosen to quit
    }

}