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

    public void RunOption(int selection, List<string> SessionData)
    {
        int _option = selection;
        int _option1 = 1;
        int _option2 = 2;
        int _option3 = 3;
        int _option4 = 4;
        int _option5 = 5;
        
        if (_option == _option1)
        {
            Entry tm_run = new Entry();
            string _entry = tm_run.CreateEntry();
            SessionData.Add(_entry);
            
        }
        else if (_option == _option2)
        {
            Entry tm_run = new Entry();
            tm_run.DisplayEntry(SessionData);
        }
        else if (_option == _option3)
        {
            Console.WriteLine("You selected Option 3");

        }
        else if (_option == _option4)
        {
            Console.WriteLine("You selected Option 4");

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

