public class Customer
{
    string _name;
    Address _address;

    public Customer()
    {
        _name = GetName();
        _address.GetAdress();
    }
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
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
}