using System;

public class Scripture
{
    // Private Attributes (Encapsulation)
    private List<Word> _scripture;      // List of words from the verse
    private Reference _reference;       // Reference to the verse (e.g., "John 3:16")


    // Constructor that accepts a reference and a text
    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        // Divides the text in words and creates an object for each word
        _scripture = text.Split(' ') // Divides the text into words
                         .Select(word => new Word(word))  // Creates a Word object for each word 
                        .ToList(); // Converts the word list to a List<Word>
    }
}