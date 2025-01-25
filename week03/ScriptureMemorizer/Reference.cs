using System;

public class Reference
{
    private string _book;           // Book of the bible, for example, "Matthew"
    private int _chapter;           // Chapter of the book
    private int _verse;             // Starting verse
    private int? _endVerse;          // Ending verse (for ranges of verses)


    // Two constructors are defined. One that accepts a book, chapter, and a starting verse.
    // The other accepts a book, chapter, starting and ending verse for ranges of verses.
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse; // If there's only 1 verse, the endVerse will be the same as the verse.
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse; // This defines a range of verses.
    }


    // Method to get the formatted reference
    public string GetDisplayText()
    {
        if (_endVerse == null || _endVerse == _verse)
        {
            return $"{_book} {_chapter}:{_verse}"; // For a single verse.
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}"; // For a verse range.
        }
    }
}