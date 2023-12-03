public class Customer
{
    string _name;
    Address _address;

    public Customer()
    {
        _name = GetName();
        _address = new Address();
    }
    public Customer(string name, string street, string city, string state, string county, bool inUSA)
    {
        _name = name;
        _address = new Address(street, city, state, county, inUSA);
    }
    public string GetName()
    {
        Console.Write("What is the name of the Customer? ");
        string name = Console.ReadLine();
        return name;
    }
    public bool InUSA()
    {
        return _address.InUSA();
    }
    public string GetShippingLable()
    {
        return _address.CreateShippingString();
    }
}