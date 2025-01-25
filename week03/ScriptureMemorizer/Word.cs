using System;
using System.Runtime.CompilerServices;

public class Word
{
    private string _text;    // The text of the word, for example, "Behold"
    private bool _isHidden;  // It indicates if the word is hidden or visible


    // This constructor initializes a Word object with the given text and sets its visibility to visible by default.
    public Word(string text)
    {
        _text = text;       // Assigns the text of the word to the private attribute.
        _isHidden = false;  // By default, the word is set to be visible when created.
    }


    // Method to hide the word
    public void HideWord()
    {
        _isHidden = true;
    }

    // Method to show the word
    public void ShowWord()
    {
        _isHidden = false;
    }

    // Method to check if word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Method to get the display text of the word
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length); // Replace letters with underscores
        }
        else
        {
            return _text; // Return the actual word text
        }
    }

}