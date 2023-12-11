public class ReceptionEvent : Event
{
    string _title;
    string _description;
    string _date;
    string _time;
    Address _address;
    string _rsvpEmail;
    string _typeOfEvent = "Reception";

    public ReceptionEvent(string title, string description, string date, string time, Address address, string email)
    {
        _title = SetTitle(title);
        _description = SetDescription(description);
        _date = SetDate(date);
        _time = SetTime(time);
        _address = SetAddress(address);
        SetEventType(_typeOfEvent);
        _rsvpEmail = email;
    }

    public void FullDetails()
    {
        StandardDetails();
        Console.WriteLine($"RSVP @ {_rsvpEmail}");
    }    
}