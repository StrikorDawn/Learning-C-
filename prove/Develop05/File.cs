
// Don't forget to put this at the top, so C# knows where to find the StreamWriter class
using System.IO; 
public class File
{
    public void WriteFile(int points, List<Goal> _goalEntry)
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
            _createFile.WriteLine(points);
            foreach (Goal item in _goalEntry)
            {
                _createFile.WriteLine(item.Format());
            }
            // You can just do a variable or you can write a string here.

            // You can add variables to files you are writing just like a normal
            // WriteLine Statement.
            Console.WriteLine($"{_fileName} has successfully been created!");
        }
    }
    
    public void ReadFile(int points, List<Goal> _sessionData)
    {
        Console.WriteLine("What is the name of the file? (The default is goal):  ");
        string _goalFile = Console.ReadLine();
        if (_goalFile == "")
        {
            _goalFile = "goal.txt";
        }
        string[] _lines = System.IO.File.ReadAllLines(_goalFile);
        foreach (string _line in _lines)
        {
            if (_line == _lines[0])
            {
                points = int.Parse(_line);
            }
            string[] parts = _line.Split("|");
            if (parts[0] == "Simple")
            {
                SimpleGoal s = new SimpleGoal();
                s.LoadGoal(parts);
                _sessionData.Add(s);
            }
            else if (parts[0] == "Eternal")
            {
                EternalGoal e = new EternalGoal();
                e.LoadGoal(parts);
                _sessionData.Add(e);
            }
            else if (parts[0] == "Checklist")
            {
                ChecklistGoal c = new ChecklistGoal();
                c.LoadGoal(parts);
                _sessionData.Add(c);
            }
            
        }
    }
}

