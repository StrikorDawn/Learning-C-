using System.Dynamic;

public class Reference
{
//  Attributes //
    private string _book;
    private string _chapter;
    private string _verseNumber;
    private string _endVerseNumber;
    private string _text;
    Scripture _scripture;
    //------------------------------------------------------------//
//  Constructor //
    public Reference(string book = "Not found", string chapter = "404", string verseNumber = "None", string text = "No scripture to memorize selected. Please selecta scripture.")
    {
        _book = book;
        _chapter = chapter;
        _verseNumber = verseNumber;
        _text = text;
        _endVerseNumber = "";
        _scripture = SetScripture();
    }
    public Reference(string book, string chapter, string verseNumber, string endVerseNumber, string text)
    {
        _book = book;
        _chapter = chapter;
        _verseNumber = verseNumber;
        _endVerseNumber = $"-{endVerseNumber}";
        _text = text;
        _scripture = SetScripture();
    }
// ------------------------------------------------------------//
//  Methods //
    public Scripture SetScripture()
    {
        Scripture scripture = new Scripture(GetReference(), GetVerse());
        return scripture;
    }
    public string GetReference()
    {
        string _heading = $"{_book} {_chapter}:{_verseNumber}{_endVerseNumber}";
        return _heading;
    }

    public string GetVerse()
    {
        return _text;
    }

    public void Practice()
    {
        string _continue = "";
        while(_continue != "quit"){
        _continue = _scripture.Display();   
        }
        
    }

    

}