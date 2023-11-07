using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("blue", 5);
        Rectangle rectangle = new Rectangle("green",7,9);
        Circle circle = new Circle("yellow",6);

        List<Shape> shapes = new List<Shape>
        {
            square, rectangle, circle
        };

        foreach (var shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}