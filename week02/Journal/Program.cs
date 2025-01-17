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
}