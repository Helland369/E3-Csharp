namespace ShapeControllSystem;

public class InOutPut
{
    private int _input;
    private double _areaTot;
    private List<Shape> _sortedList;
    
    private List<Shape> _shapes = new List<Shape>
    {
        new Circle(6.3, "Circle 1", "Green"),
        new Circle(9.6, "Circle 2", "Blue"),
        new Triangle(16.3,6.9, "Triangle 1", "Purple"),
        new Triangle(22.3,12.3, "Triangle 2", "Pink"),
        new Rectangle(21.3,13.3, "Rectangle 1", "Grey"),
        new Rectangle(23.3,14.3, "Rectangle 2", "Yellow"),
    };

    public InOutPut()
    {
        MainMenu();
    }
    
    private void PrintShapeInfo()
    {
        foreach (Shape shape in _shapes)
        {
                shape.PrintInfo();
        }
    }

    private void CalculateTotalArea()
    {
        foreach (Shape shape in _shapes)
        {
            _areaTot += shape.CalculateArea();
        }
        Console.WriteLine(_areaTot.ToString());
    }

    private void SortByArea()
    {
        _sortedList = _shapes.OrderBy(shape => shape.CalculateArea()).ToList();

        foreach (Shape shape in _sortedList)
        {
            shape.PrintInfo();
        }
    }

    private void SortByColour()
    {
        _sortedList = _shapes.OrderBy(shape => shape.Colour).ToList();

        foreach(Shape shape in _sortedList)
        {
            shape.PrintInfo();
        }
    }
    
    public void MainMenu()
    {
        while (true)
        {
            Console.WriteLine("[1] Print shape information\n" +
                              "[2] Print total area\n" +
                              "[3] Sort by area\n" +
                              "[4] Sort by colour\n" +
                              "[0] EXIT");
            
            int input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 0:
                    return;
                case 1:
                    PrintShapeInfo();
                    break;
                case 2:
                    CalculateTotalArea();
                    break;
                case 3:
                    SortByArea();
                    break;
                case 4:
                    SortByColour();
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}