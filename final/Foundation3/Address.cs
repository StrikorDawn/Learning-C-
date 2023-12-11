public class Address
{
    string _number;
    string _street;
    string _city;
    string _state; 
    int _zip;
    public Address(string number, string street, string city, string state, int zip)
    {
        _number = number;
        _street = street;
        _city = city;
        _state = state;
        _zip = zip;
    }

    public string Display()
    {
        return $"{_number} {_street}\n{_city}, {_state}, {_zip}";
    }
}