public class LectureEvent : Event
{
    string _title;
    string _description;
    string _date;
    string _time;
    Address _address;
    string _typeOfEvent= "Lecture";
    string _speaker;
    int _capacity;

    public LectureEvent(string title, string description, string date, string time, Address address,string speaker, int capacity)
    {
        _title = SetTitle(title);
        _description = SetDescription(description);
        _date = SetDate(date);
        _time = SetTime(time);
        _address = SetAddress(address);
        SetEventType(_typeOfEvent);
        _speaker = speaker;
        _capacity = capacity;
    }

    public void FullDetails()
    {
        StandardDetails();
        Console.WriteLine(_typeOfEvent);
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Capacity: {_capacity}");
    }
}