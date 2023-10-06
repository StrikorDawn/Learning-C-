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
        Prompt _question = new Prompt();
        string _prompt = _question.DisplayRandomPrompt();
        Console.Write("> ");
        string _response = Console.ReadLine();
        _response = $"{_entryDate} {_prompt}\n{_response}\n";
        return _response;
    }

    public void DisplayEntry(List<string> _entries)
    {
        foreach (string _item in _entries)
            {
                Console.WriteLine(_item);
            }
        Console.Write("Press any key to continue...");
        Console.ReadLine();
    }

}