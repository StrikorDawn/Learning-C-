public class Circle : Shape
{
    private double _radius;
    double pi = Math.PI;

    public Circle(string color, double radius)
    {
        _radius = radius;
        SetColor(color);

    }

    public override double GetArea()
    {
        return pi * (_radius*_radius);
    }
}