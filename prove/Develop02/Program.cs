using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        List<string> _sessionData = new List<string>();
        int _selection = 0;
        while(_selection != 5)
        {
            Menu _nav = new Menu();
            _nav.Display();
            _selection = _nav.GetSelection();
            _nav.RunOption(_selection, _sessionData);
        
        }
    }
}