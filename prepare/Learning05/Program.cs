using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        Square s = new Square("blue", 5);
        s.GetColor();
        s.GetArea();
        Console.WriteLine($"{s.GetColor()} {s.GetArea()}");

        Rectangle r = new Rectangle("green", 4, 6);
        r.GetColor();
        r.GetArea();
        Console.WriteLine($"{r.GetColor()} {r.GetArea()}");

        Circle c = new Circle("red", 5);
        
        c.GetColor();
        c.GetArea();
        Console.WriteLine($"{c.GetColor()} {c.GetArea()}");

        List<Shape> _shapes = new List<Shape>();
        _shapes.Add(s);
        _shapes.Add(r);
        _shapes.Add(c);

        foreach (Shape shape in _shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"{color} {area}");

        }


    }
}