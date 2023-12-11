public class OutdoorEvent : Event
{
    string _title;
    string _description;
    string _date;
    string _time;
    Address _address;
    string _weather;
    string _typeOfEvent = "Outdoor";

    public OutdoorEvent(string title, string description, string date, string time, Address address, string weather)
    {
        _title = SetTitle(title);
        _description = SetDescription(description);
        _date = SetDate(date);
        _time = SetTime(time);
        _address = SetAddress(address);
        SetEventType(_typeOfEvent);
        _weather = weather;
        
    }

    public void FullDetails()
    {
        StandardDetails();
        Console.WriteLine($"The weather forcast for the event is: {_weather}");
    }   
}