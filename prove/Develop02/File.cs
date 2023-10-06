
// Don't forget to put this at the top, so C# knows where to find the StreamWriter class
using System.IO; 
public class File
{
    public void WriteFile(List<string> _journalEntry)
    {
        Console.WriteLine("What would you like to call this journal?");
        string _journalName = Console.ReadLine();
        string _fileName = _journalName;

        using (StreamWriter createFile = new StreamWriter(_fileName))
        {   
            string _journal = _fileName;
            foreach (string line in _journalEntry)
            {
                createFile.WriteLine(line);
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
        string[] lines = System.IO.File.ReadAllLines(_journalName);
        foreach (string line in lines)
        {
            _sessionData.Add(line);
        }
    }
}

