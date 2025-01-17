using System;
using System.Collections.Generic;

public class Journal
{
    private List<Entry> _entries; // This is a private list to store all journal entries

    public Journal()
    {
        _entries = new List<Entry>(); // Initialize the list when a Journal is created
    }

    // Method to add a new jorunal entry to the list
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    // Method to display all journal entries
    public void DisplayAll()
    {
        foreach (var entry in _entries) // Loop through each entry in the list.
        {
            entry.Display(); // Call the Display method of each entry to print it.
        }
    }

    // Method to save the journal entries to a file
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename)) // Open a file to write to
        {
            foreach (var entry in _entries)
            {
                // Write each entry in the format: Date|Prompt|Prompt Entry
                writer.WriteLine($"{entry.Date}|{entry.PromptText}|{entry.EntryText}");
            }
        }
    }

    public void AddEntry(Entry newEntry)
    {

    }

    public void DisplayAll()
    {

    }

    public void SaveToFile(string filename)
    {

    }

    public void LoadFromFile(string filename)
    {

    }
}