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
                // Write each entry in the format: Date|Prompt|Prompt|Time Entry
                writer.WriteLine($"{entry.Date}|{entry.PromptText}|{entry.EntryText}|{entry.Time}");
            }
        }
    }

    // Method to load journal entries from a file
    public void LoadFromFile(string filename)
    {
        _entries.Clear(); // Clear any existing before loading the file.
        using (StreamReader reader = new StreamReader(filename)) // Open the file for reading
        {
            string line;
            while ((line = reader.ReadLine()) != null) // Read the file line by line
            {
                // Split the line into parts: Date|Prompt|Entry|Time
                string[] parts = line.Split('|');
                if (parts.Length == 4) // Ensure the line has the correct number of parts
                {
                    string date = parts[0];
                    string promptText = parts[1];
                    string entryText = parts[2];
                    string entryTime = parts[3];

                    // Create a new Entry and add it to the list
                    Entry entry = new Entry(date, promptText, entryText, entryTime);
                    _entries.Add(entry);
                }
            }
        }
    }
}