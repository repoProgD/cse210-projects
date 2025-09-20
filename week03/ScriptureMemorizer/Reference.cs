/*
Keeps track of the book, chapter, and verse information.
*/

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    // Function overloading is not exclusive to constructors
    public Reference(string book, int chapter, int verse, int endVerse) /* this optional parameter acts as a sentinel, it's not an actual verse value*/
    {                                                                        /* -1 means there is only one verse in the reference */
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    // I need to return different formats according to what constructor was used.
    {
        if (_endVerse > 0) // constructor for extended reference. C# defaults int to 0, so I can use it as a sentinel.
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        else { 
            return $"{_book} {_chapter}:{_verse}";
        }
        
    }
}