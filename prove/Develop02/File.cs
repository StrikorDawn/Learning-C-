
// Don't forget to put this at the top, so C# knows where to find the StreamWriter class
using System.IO; 
public class File
{
    public void WriteFile(List<string> _journalEntry)
    {
        Console.WriteLine("What would you like to call this journal? (The default is Journal) ");
        string _journalName = Console.ReadLine();
        string _fileName;
        
        if (_journalName == "")
        {
            _fileName = "Journal.txt";
        }

        else{
            _fileName = _journalName;
        }

        using (StreamWriter _createFile = new StreamWriter(_fileName))
        {   
            string _journal = _fileName;
            foreach (string _line in _journalEntry)
            {
                _createFile.WriteLine(_line);
            }
            // You can just do a variable or you can write a string here.

            // You can add variables to files you are writing just like a normal
            // WriteLine Statement.
            Console.WriteLine($"{_journal} has successfully been created!");
        }
    }
    
    public void ReadFile(List<string> _sessionData)
    {
        Console.WriteLine("What is the name of the journal?");
        string _journalName = Console.ReadLine();
        string[] _lines = System.IO.File.ReadAllLines(_journalName);
        foreach (string _line in _lines)
        {
            _sessionData.Add(_line);
        }
    }
}

