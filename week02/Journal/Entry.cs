using System;

public class Entry
{
    public Entry(string date, string promptText, string entryText)
    {
        Date = date;
        PromptText = promptText;
        EntryText = entryText;
    }

    public string Date { get; } // Holds the date of the entry, the data cannot be modified after initialization.
    public string PromptText { get; } // Stores the prompt question related with the journal entry.
    public string EntryText { get; } // Stores the user's written response to the prompt.


    public void Display()
    {

    }

}