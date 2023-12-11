public class Event
{
    string _title;
    string _description;
    string _date;
    string _time;
    Address _address;
    string eventType;

    public Event()
    {
        _title = "Test Title";
        _description = "This is a test description";
        _date = "12/15/2023";
        _time = "6:30";
        _address = new Address("555","TestStreet","City","STATE",55555);
        eventType = "Unregestered event";
    }

    public string SetTitle(string input)
    {
        _title = input;
        return input;
    }
    public string SetDescription(string input)
    {
        _description = input;
        return input;
    }
    public string SetDate(string input)
    {
        _date = input;
        return input;
    }
    public string SetTime(string input)
    {
        _time = input;
        return input;
    }
    public Address SetAddress(Address input)
    {
        _address = input;
        return input;
    }
    public string SetEventType(string input)
    {
        eventType = input;
        return input;
    }
    public void StandardDetails()
    {
        Console.WriteLine($"{_title}");
        Console.WriteLine(_description);
        Console.WriteLine($"{_date} @ {_time}");
        Console.WriteLine(_address.Display());
    }

    public void ShortDescription()
    {
        Console.WriteLine($"{eventType}: {_title} {_date}");
    }
}