using System.Security.Cryptography;

public class Order
{
    Customer _customer;
    List<Product> _products;
    float _totalPrice;
    float _subTotal;
    float _shippingFee;
    public Order()
    {
        _customer = new Customer();
        _products = new List<Product>();
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
            item.ComputePrice();
        }
    }
    public void DisplayPackingLable()
    {

    }
    public void DisplayShippingLable()
    {

    }
}