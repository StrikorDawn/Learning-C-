using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class Menu
{
    // Couldn't Figure out how to add multiple variables into a list in one go.
    int _points = 0;

    public List<string> _menu = new List<string>
    {
        "1. Create New Goal",
        "2. List Goals",
        "3. Save Goals",
        "4. Load Goals",
        "5. Record Event",
        "6. Quit"
    };

    public void Display()
    {
        Console.WriteLine();
        Console.WriteLine($"You have {_points} points.");
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        foreach(string option in _menu)
        {
            Console.WriteLine($"  {option}");
        }
    }

    public int GetSelection()
    {
        Console.Write("Select a choice from the menu: ");
        string _option = Console.ReadLine();
        int _select = int.Parse(_option);
        return _select;
    }

    public void RunOption(int _selection)
    {
        int _option = _selection;
        int _option1 = 1;
        int _option2 = 2;
        int _option3 = 3;
        int _option4 = 4;
        int _option5 = 5;
        int _quit = 6;
        
        if (_option == _option1)
        {
            
        }
        else if (_option == _option2)
        {

        }
        else if (_option == _option3)
        {
            File _create = new File();
            // _create.WriteFile();

        }
        else if (_option == _option4)
        {
            File _read = new File();
            // _read.ReadFile();
            

        }
        else if(_option == _option5)
        {
        
        }
        else if(_option == _quit)
        {
            Console.WriteLine("Thank you for using The Journal, Have a wonderful day!");
        }
        else
        {
            Console.WriteLine("Please enter a valid numereical option.");
            
        }
    }
    
    public void Run()
    {
        int _userInput = 0;
        while (_userInput != 6)
        {
            Display();
            _userInput = GetSelection();
            RunOption(_userInput);
        };
    }
}

