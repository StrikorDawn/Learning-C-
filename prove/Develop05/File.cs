
// Don't forget to put this at the top, so C# knows where to find the StreamWriter class
using System.IO; 
public class File
{
    public void WriteFile(List<string> _goalEntry)
    {
        Console.WriteLine("What would you like to call this file? (The default is goal): ");
        string _goalName = Console.ReadLine();
        string _fileName;
        
        if (_goalName == "")
        {
            _fileName = "goal.txt";
        }

        else{
            _fileName = _goalName;
        }

        using (StreamWriter _createFile = new StreamWriter(_fileName))
        {   
            string _goal = _fileName;
            foreach (string _line in _goalEntry)
            {
                _createFile.WriteLine(_line);
            }
            // You can just do a variable or you can write a string here.

            // You can add variables to files you are writing just like a normal
            // WriteLine Statement.
            Console.WriteLine($"{_goal} has successfully been created!");
        }
    }
    
    public void ReadFile(List<string> _sessionData)
    {
        Console.WriteLine("What is the name of the file? (The default is goal):  ");
        string _goalName = Console.ReadLine();
        if (_goalName == "")
        {
            _goalName = "goal.txt";
        }
        string[] _lines = System.IO.File.ReadAllLines(_goalName);
        foreach (string _line in _lines)
        {
            _sessionData.Add(_line);
        }
    }
}

