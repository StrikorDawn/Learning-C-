public class JournalSelect
{
    private List<string> _journalList = new List<string>
    {
        "Main Journal.txt",
        "Spiritual Thoughts.txt",
        "D&D Notes"
    };
    private int _journalNumber = 0;
    
    public void DisplayJournals()
    {
        Console.WriteLine();
        Console.WriteLine("***************************************************************");
        Console.WriteLine("Here are your list of journals, which would you like to select?");
        foreach (string journal in _journalList)
        {
            _journalNumber += 1;
            Console.WriteLine($"{_journalNumber}. {journal}");
        }
        Console.WriteLine();
        Console.Write("Press any key to continue...");
        Console.ReadLine();
    }  
}