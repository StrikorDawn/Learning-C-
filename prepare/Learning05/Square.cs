public class Square : Shape
{
    double _sideLength;
    public Square(string color, double sideLength)
    {
        _sideLength = sideLength;
        SetColor(color);
    }

    public override double GetArea()
    {
        return _sideLength*_sideLength;
    }
}