namespace ShapeControllSystem;

public class Rectangle : Shape
{
    private double _length, _width;

    public Rectangle(double length, double height, string name, string colour) : base(name, colour)
    {
        _length = length; _width = height;
    }
    
    public double GetLength() { return _length; }
    public double GetWidth() { return _width; }

    override public double CalculateArea()
    {
        return _length * _width;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Name: {_name}\nColour: {_colour}\n" + 
                          $"Length: {_length}\nWidth: {_width}\nArea: {CalculateArea()}\n");
    }
}