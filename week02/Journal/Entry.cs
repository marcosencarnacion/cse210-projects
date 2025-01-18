using System;

public class Entry
{
    public string Date { get; } // Holds the date of the entry, the data cannot be modified after initialization.
    public string PromptText { get; } // Stores the prompt question related with the journal entry.
    public string EntryText { get; } // Stores the user's written response to the prompt.
    public string Time { get; } // Exceeding requirements. New property for timestamp. New info saved in Journal entry.


    // Construct to create a new entry with the date, promtp, and entry text
    public Entry(string date, string promptText, string entryText, string time)
    {
        Date = date;
        PromptText = promptText;
        EntryText = entryText;
        Time = time;
    }


    // Method to display the journal
    public void Display()
    {
        Console.WriteLine($"Date: {Date} {Time}"); // Include the date and time in the display. Exceeding requirements.
        Console.WriteLine($"Prompt: {PromptText}");
        Console.WriteLine($"Entry: {EntryText}\n");
    }

}