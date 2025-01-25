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
        Random random = new Random();
        int wordsHidden = 0;

        // Continue the loop until we hide the specified number of words
        while (wordsHidden < numberToHide)
        {
            // Pick a random index within the list of words
            int index = random.Next(_scripture.Count); // Random index between 0 and the number of words

            // Check if the word is already hidden
            if (!_scripture[index].IsHidden())
            {
                _scripture[index].HideWord(); // Call the method on the Word object
                wordsHidden++;                // Increment the number of words hidden
            }
        }

    }

    // Method to get the scripture display text
    public string GetDisplayText()
    {
        string displayText = $"{_reference.GetDisplayText()} "; // Get the reference text (e.g. 1 Nephi 3:7)

        foreach (var word in _scripture)
        {
            displayText += word.GetDisplayText() + " "; // Add the display text of each word
        }

        return displayText.Trim(); // Remove the trailing space
    }


    // Method to check if all words are hidden
    public bool IsCompletelyHidden()
    {
        foreach (var word in _scripture)
        {
            if (!word.IsHidden()) // If any word is not hidden, return false
            {
                return false;
            }
        }

        return true; // All words are hidden
    }
}