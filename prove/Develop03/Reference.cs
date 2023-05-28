public class Reference
{
    private string _book, _chapter, _verse, _endVerse;

    public Reference()
    {
    }

    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = "";
    }

    public Reference(string book, string chapter, string verse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public void GetRenderedText()
    {
        if(_endVerse == "") Console.Write($"{_book} {_chapter}:{_verse}");
        else Console.Write($"{_book} {_chapter}:{_verse}-{_endVerse}");
    }
}