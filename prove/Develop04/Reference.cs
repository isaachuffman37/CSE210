public class Reference
{
    string _book;
    string _StartVerse;
    string _EndVerse;
    string _chapter;


    public Reference(string book, string chapter, string StartVerse, string Endverse)
    {
        _book = book;
        _StartVerse = StartVerse;
        _EndVerse = Endverse;
        _chapter = chapter;
    }

    public string Display()
    {
        if (_EndVerse == null)
        {
            return ($"{_book} {_chapter}:{_StartVerse}");
        }
        else 
        {
            return $"{_book} {_chapter}:{_StartVerse}-{_EndVerse}";
        }
    }
}