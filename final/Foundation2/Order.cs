public class Order
{
    Customer _customer;
    List<Product> _products = new List<Product>();
    float _totalPrice;
    float _subTotal;
    float _shippingFee;
    public Order()
    {
        _customer = new Customer();
    }
    public Order(string customer, string street, string city, string state, string county, bool inUSA)
    {
        _customer = new Customer(customer, street, city, state, county, inUSA);

    }
    public void AddProduct()
    {
        Product product = new Product();
        _products.Add(product);
    }
    public void CalculateSubTotal()
    {
        foreach (var item in _products)
        {
            _subTotal += item.ComputePrice();
        }
    }
    public float CalculateTotal()
    {
        if (_customer.InUSA())
        {
            _shippingFee = 5;
        }
        else
        {
            _shippingFee = 35;
        }
        return _totalPrice = _subTotal + _shippingFee;
    }
    public void DisplayPackingLable()
    {
        foreach (var item in _products)
        {
            Console.WriteLine($"{item.GetNumber()} - {item.GetName()}: {item.GetID()}");            
        }
        Console.WriteLine($"${_totalPrice}");
    }
    public void DisplayShippingLable()
    {
        Console.WriteLine(_customer.GetShippingLable());
    }
}