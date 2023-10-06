public class Entry
{
    private string GetDate()
    {
        DateTime _theCurrentTime = DateTime.Now;
        string _dateText = _theCurrentTime.ToShortDateString();
        return _dateText;
    }
    public string CreateEntry()
    {
        string _entryDate = GetDate();
        Prompt tm_question = new Prompt();
        tm_question.DisplayRandomPrompt();
        Console.Write("> ");
        string _response = Console.ReadLine();
        _response = $"{_entryDate}\n{_response}";
        return _response;
    }

    public void DisplayEntry(List<string> _entries)
    {
        foreach (string item in _entries)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }
        Console.Write("Press any key to continue...");
        Console.ReadLine();
    }

}