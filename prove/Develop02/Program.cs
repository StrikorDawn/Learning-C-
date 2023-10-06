using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        List<string> SessionData = new List<string>();
        int tm_selection = -1;
        while(tm_selection != 5)
        {
            Menu tm_nav = new Menu();
            tm_nav.Display();
            tm_selection = tm_nav.GetSelection();
            tm_nav.RunOption(tm_selection, SessionData);
        
        }
    }
}