public class Rectangle : Shape
{
    double _base;
    double _height;
    public Rectangle(string color, double width, double height) : base(color)
    {
        _base = width;
        _height = height;
    }

    public override double GetArea()
    {
        return _base * _height;
    }
}