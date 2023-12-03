public class Product
{
    string _name;
    string _productID;
    float _price;
    int _quantity;
    public Product()
    {
        Console.Write("");
        _name = Console.ReadLine();
        Console.Write("");
        _productID = Console.ReadLine();
        Console.Write("");
        _price = float.Parse(Console.ReadLine());
        Console.Write("");
        _quantity = int.Parse(Console.ReadLine());
    }
    public Product(string name, string ID, float price, int quantity)
    {
        _name = name;
        _productID = ID;
        _price = price;
        _quantity = quantity;
    }

    public float ComputePrice()
    {
        float _cost = _quantity * _price;
        return _cost;
    }
}