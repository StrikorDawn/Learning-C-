public class Address
{
    string _street;
    string _city;
    string _state;
    string _country;
    bool _inUSA;
    public Address()
    {
        GetAdress();
    }
    public Address(string street, string city, string state, string county, bool inUSA)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = county;
        _inUSA = inUSA;
    }
    public void GetAdress()
    {
        Console.WriteLine("What is the Country Name? ");
        _country = GetString();
        if (_country == "USA" || _country == "United States of America" || _country == "United States")
        {
            Console.WriteLine("What is the State Name? ");
            _inUSA = true;
        }
        else
        {
            Console.WriteLine("What is the Providence Name? ");
            _inUSA = false;
        }
        _state = GetString();
        Console.WriteLine("What is the City Name? ");
        _city = GetString();
        Console.WriteLine("What is the Street Name? ");
        _street = GetString();
    }
    public string GetString()
    {
        return Console.ReadLine();
    }
    public bool InUSA()
    {
        return _inUSA;
    }
    public string CreateShippingString()
    {
        return $"{_street} \n{_city}, {_state} {_country}";
    }   
}