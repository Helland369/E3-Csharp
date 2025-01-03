namespace ShapeControllSystem;

public abstract class Shape
{
    protected string _name, _colour;

    public Shape(string name, string colour)
    {
        _name = name;
        _colour = colour;
    }
    
    public string Name { get => _name; set => _name = value; }
    public string Colour { get => _colour; set => _colour = value; }
    
    public abstract double CalculateArea();

    public virtual void PrintInfo() {}

}