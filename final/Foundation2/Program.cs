using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Order order1 = new Order("Bob", "288 W Hidden Meadow Way", "Middleton", "Idaho", "USA", true);
            order1.AddProduct();
            order1.AddProduct();
            order1.AddProduct();
            order1.CalculateSubTotal();
            order1.CalculateTotal();
            order1.DisplayPackingLable();
            order1.DisplayShippingLable();
            Console.WriteLine();
        Order order2 = new Order("Jeff", "3654 S 4 E", "New York City", "New York", "USA", true);
            order2.AddProduct();
            order2.AddProduct();
            order2.AddProduct();
            order2.CalculateSubTotal();
            order2.CalculateTotal();
            order2.DisplayPackingLable();
            order2.DisplayShippingLable();
            Console.WriteLine();
        Order order3 = new Order("Juan", "33 S Sand St", "Papas", "South Chile", "Chile", false);
            order3.AddProduct();
            order3.AddProduct();
            order3.AddProduct();
            order3.CalculateSubTotal();
            order3.CalculateTotal();
            order3.DisplayPackingLable();
            order3.DisplayShippingLable();
    }
}