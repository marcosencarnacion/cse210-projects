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

    // Method to hide a number of random words
    public void HideRandomWords(int numberToHide)
    {

    }

    // Method to get the scripture display text
    public string GetDisplayText()
    {

    }

    // Method to check if all words are hidden
    public bool IsCompletelyHidden()
    {

    }
}