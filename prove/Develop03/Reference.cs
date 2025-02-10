public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int? _endVerse;
    private string _verseText;

    public Reference()
    {
        _book = "John";
        _chapter = 3;
        _startVerse = 16;
        _endVerse = null;
    }

    public Reference(string book, int chapter, int startVerse, string verseText) // new constructor for 1 verse using scriptureGenerator
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = null;
        _verseText = verseText;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse, string verseText)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
        _verseText = verseText;
    }

    public string GetReference()
    {
        if (_endVerse == null)
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
    }  

    public string GetVerseText()
    {
        return _verseText;
    }
}