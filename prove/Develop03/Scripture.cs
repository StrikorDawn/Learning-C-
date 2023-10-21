using System.Dynamic;
using System.Runtime.CompilerServices;

public class Scripture
{
//  Attributes //
    private string _reference;
    private string _scriptureText;
    private List<string> _hiddenWords;
    Word word;
    
//------------------------------------------------------------//
//  Constructor //
    public Scripture(string reference, string text)
    {
        _reference = reference;
        _scriptureText = text;  
        _hiddenWords = new List<string>();
        word = SetWord();      
    }   
// ------------------------------------------------------------//
//  Methods //
    public Word SetWord()
    {
        Word word = new Word(GetScripture());
        return word;

    }

    public string GetScripture()
    {
        return _scriptureText;
    }
    
    public string Display()
    {
        _scriptureText = word.GetRenderedText(_hiddenWords);
        Console.Clear();
        Console.WriteLine($"{_reference} {_scriptureText}");
        string _user = Continue();
        return _user;

    }
    

    public string Continue()
    {
        Console.WriteLine("\nPress enter to continue or type 'quit' to finish:\n");
        string _input = Console.ReadLine();
        bool _allHidden = word.AllHidden();
        if (_input != "quit")
        {
            _hiddenWords = word.HideWord();
        }
        else if (_allHidden)
        {
            _input = "quit";
        }
        return _input;
    }
}