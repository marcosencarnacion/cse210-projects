using System;

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
}