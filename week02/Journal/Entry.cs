using System;

public class Entry
{
    public string Date { get; } // Holds the date of the entry, the data cannot be modified after initialization.
    public string PromptText { get; } // Stores the prompt question related with the journal entry.
    public string EntryText { get; } // Stores the user's written response to the prompt.


    // Construct to create a new entry with the date, promtp, and entry text
    public Entry(string date, string promptText, string entryText)
    {
        Date = date;
        PromptText = promptText;
        EntryText = entryText;
    }


    // Method to display the journal
    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {PromptText}");
        Console.WriteLine($"Entry: {EntryText}\n");
    }

}