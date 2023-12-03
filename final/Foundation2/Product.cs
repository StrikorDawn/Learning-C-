public class Product
{
    string _name;
    string _productID;
    float _price;
    int _quantity;
    public Product()
    {
        Console.Write("What is the Name of the Poduct? ");
        _name = Console.ReadLine();
        Console.Write("What is the ID of the Product? ");
        _productID = Console.ReadLine();
        Console.Write("What is the Price of the Product? ");
        _price = float.Parse(Console.ReadLine());
        Console.Write("How many are being purchased? ");
        _quantity = int.Parse(Console.ReadLine());
    }
    public Product(string name, string ID, float price, int quantity)
    {
        _name = name;
        _productID = ID;
        _price = price;
        _quantity = quantity;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetID()
    {
        return _productID;
    }
    public int GetNumber()
    {
        return _quantity;
    }
    public float ComputePrice()
    {
        float _cost = _quantity * _price;
        return _cost;
    }
}