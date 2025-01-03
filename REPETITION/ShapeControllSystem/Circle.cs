namespace ShapeControllSystem;

public class Circle : Shape
{
    private double _radius;

    public Circle(double radius, string name, string colour) : base(name, colour)
    {
        _radius = radius;
    }
    
    public double GetRadius() { return _radius; }
    
    public override double CalculateArea()
    {
        return Math.PI * _radius * _radius;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Name: {_name}\nColour: {_colour}\n" + 
                          $"Radius: {_radius}\nArea: {CalculateArea()}\n");
    }
}