using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class Menu
{
    // Couldn't Figure out how to add multiple variables into a list in one go.
    

    public List<string> _menu = new List<string>
    {
        "1. Write New Entry",
        "2. Display Journal",
        "3. Save Journal",
        "4. Load File",
        "5. Quit"
    };

    public void Display()
    {
        Console.WriteLine();
        Console.WriteLine("***************************************************************");
        Console.WriteLine("Welcome to the Journal. Please select one of the options below.");
        Console.WriteLine("Type the number of the action you would like to perform.");
        foreach(string option in _menu)
        {
            Console.WriteLine(option);
        }
        Console.WriteLine();
    }

    public int GetSelection()
    {
        Console.Write("What would you like to do? ");
        string _option = Console.ReadLine();
        int _select = int.Parse(_option);
        return _select;
    }

    public void RunOption(int _selection, List<string> _sessionData)
    {
        int _option = _selection;
        int _option1 = 1;
        int _option2 = 2;
        int _option3 = 3;
        int _option4 = 4;
        int _option5 = 5;
        
        if (_option == _option1)
        {
            Entry _run = new Entry();
            string _entry = _run.CreateEntry();
            _sessionData.Add(_entry);
            
        }
        else if (_option == _option2)
        {
            Entry _show = new Entry();
            _show.DisplayEntry(_sessionData);
        }
        else if (_option == _option3)
        {
            File _create = new File();
            _create.WriteFile(_sessionData);

        }
        else if (_option == _option4)
        {
            File _read = new File();
            _read.ReadFile(_sessionData);
            

        }
        else if(_option == _option5)
        {
            Console.WriteLine("Thank you for using The Journal, Have a wonderful day!");
        }
        else
        {
            Console.WriteLine("Please enter a valid numereical option.");
            
        }
    }
    
}

