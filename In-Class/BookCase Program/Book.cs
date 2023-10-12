public class Book
{
    private string _author;
    private string _name;
    private int _timesRead;
    private bool _available;

    public Book(string name, string author)
    {
        _name = name;
        _author = author;
        _timesRead = 0;
        _available = true;
    }

    public void DisplayBook()
    {
        Console.WriteLine($"{_name}")
        Console.WriteLine($"{_author}")
        Console.WriteLine($"{_timesRead}")
        Console.WriteLine($"{_available}")
    }

    public IsAvailable()
    {

    }

    public TimesRead()
    {

    }

    public CheckOut()
    {

    }

    public CheckIn()
    {

    }
    public bool HasAuthor(string author)
    {
        return _author.Contains(author);
    }
}