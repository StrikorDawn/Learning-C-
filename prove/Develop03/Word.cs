using System.ComponentModel.DataAnnotations;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

public class Word
{
//  Attributes //
    private string _scriptureText;
    private List<string> _words;
    private List<bool> _display;
    private int _numWord;
    Random _random = new Random();
//------------------------------------------------------------//
//  Constructor //
    public Word(string text)
    {
        _scriptureText = text;
        _words = new List<string>();
        _display = new List<bool>();
        SplitVerse(_scriptureText);
        _numWord = _words.Count;
    }
// ------------------------------------------------------------//
//  Methods //   
// Creates 2 lists of words and Boolian to help remove words.
    public void SplitVerse(string verse)
    {
        List<string> split = verse.Split(" ").ToList();
        foreach (var item in split)
        {
            _words.Add(item);
            _display.Add(true);
        }
    }
// This is the method that iterates throught to remove a word.
    public List<string> HideWord()
    {
        int _hideNum = HideNumber();
        for (int i = 0; i < _hideNum; i++)
        {   
            int _hide = CheckNumber();
            string _hidWord = _words[_hide];
            _display[_hide] = false;
            _words[_hide] = new string('_', _hidWord.Length);
        }
        return _words;

    }

    // Selects the Number of Words to be hidden.
    public int HideNumber()
    {
        return _random.Next(1,5);
    }
    // Selects the words to be hidden.
    public int Hide()
    {
        return _random.Next(0, _numWord);
    }
    public int CheckNumber()
    {
        // There is something wrong with this section of the Code it messes up the last itereation of the Program.
        int _check;
        if (!AllHidden())
        {
            do
            {
                _check = Hide();
            }while(!_display[_check]);
            return _check;
        }
        else{
            _check = 0;
            return _check;
        }
    }
    public string GetRenderedText(List<string> hiddenWords)
    {
        string _hiddenScripture = "";
        foreach(string item in _words)
        {
            if(item == _words[0])
            {
                _hiddenScripture = item;
                Console.WriteLine(item);
                Console.WriteLine(_hiddenScripture);
            }
            else
            {
                _hiddenScripture =$"{_hiddenScripture} {item}";
                Console.WriteLine(item);
                Console.WriteLine(_hiddenScripture);
            }
        }
        return _hiddenScripture;
    }

        public bool AllHidden()
    {
        bool _allHidden = true;
        for (int i = 0; i < _display.Count; i++)
        {
            if(_display[i] == true)
            {
                _allHidden = false;
            }
        }
        return _allHidden;
    }
    
}