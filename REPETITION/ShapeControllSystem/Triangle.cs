namespace ShapeControllSystem;

public class Triangle : Shape
{
    private double _base, _height;

    public Triangle(double baseRadius, double height, string name, string colour) : base(name, colour)
    {
        _base = baseRadius; _height = height;
    }
    
    public double GetBase() { return _base; }
    public double GetHeight() { return _height; }

    override public double CalculateArea()
    {
        return 0.5 * _base * _height;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Name: {_name}\nColour: {_colour}\n" + 
                          $"Base: {_base}\nHeight: {_height}\nArea: {CalculateArea()}\n");
    }
}