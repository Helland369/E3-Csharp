namespace ShapeControllSystem
{


    class MainShape
    {

        private double totArea;

        List<Shape> shapes = new List<Shape> {
            new Circle("Circle 1", "Green", 25),
            new Circle("Circle 2", "Blue", 35),
            new Rectangle("Rectangle 1","Purple",5.1,3.7),
            new Rectangle("Rectangle 2","Yellow",3.2,5.4),
            new Triangle("Triangle 1","Grey",6.6,3.0),
            new Triangle("Triangle 2","Cyan",6.3,9.9),
        };

        private double calculateTotalArea()
        {

            for (int i = 0; i < shapes.Count; i++)
            {
                totArea += shapes[i].calculateAerea();
            }

            return totArea;
        }

        private void sortList()
        {

            shapes.Sort((x, y) => x.calculateAerea().CompareTo(y.calculateAerea()));

            Console.WriteLine("----------------------");
            Console.WriteLine("Sorted List");
            Console.WriteLine("----------------------");

            foreach (Shape shape in shapes)
            {
                if (shape is Circle circle)
                {
                    Console.WriteLine($"Name: {circle._Name}\n" +
                                      $"Colour: {circle._Colour}\n" +
                                      $"Radius: {circle._Radius}\n" +
                                      $"Area: {circle.calculateAerea()}");
                    Console.WriteLine("-------------------------");
                }
                else if (shape is Rectangle rectangle)
                {
                    Console.WriteLine($"Name: {rectangle._Name}\n" +
                                      $"Colour: {rectangle._Colour}\n" +
                                      $"Lenght: {rectangle._Length}\n" +
                                      $"Width: {rectangle._Width}\n" +
                                      $"Area: {rectangle.calculateAerea()}");
                    Console.WriteLine("-------------------------");
                }
                else if (shape is Triangle triangle)
                {
                    Console.WriteLine($"Name: {triangle._Name}\n" +
                                      $"Colour: {triangle._Colour}\n" +
                                      $"Height: {triangle._Height}\n" +
                                      $"Base: {triangle._TriangleBase}\n" +
                                      $"Area: {triangle.calculateAerea()}");
                    Console.WriteLine("-------------------------");
                }
            }
        }

        private void filterColours()
        {
            Console.WriteLine("Write the colour you want to find");
            string usrInput = Console.ReadLine().ToUpper();

            foreach (Shape shape in shapes)
            {
                if (usrInput == shape._Colour.ToUpper())
                {
                    Console.WriteLine($"Name: {shape._Name} Colour: {shape._Colour}");
                }
            }
        }

        private void filterColourTwo()
        {
            Console.WriteLine("Colour search 2.0");
            string usrInput = Console.ReadLine().ToUpper();

            var filteredShapes = shapes.Where(x => x._Colour.ToUpper() == usrInput);

            if (!filteredShapes.Any())
            {
                Console.WriteLine("There is no shape with that colour!");
            }
            else
            {
                foreach (Shape shape in filteredShapes)
                {
                    Console.WriteLine($"Name: {shape._Name} Colour: {shape._Colour}");
                }
            }
        }

        private void printInfo()
        {


            foreach (Shape shape in shapes)
            {
                if (shape is Circle circle)
                {
                    Console.WriteLine($"Name: {circle._Name}\n" +
                                      $"Colour: {circle._Colour}\n" +
                                      $"Radius: {circle._Radius}\n" +
                                      $"Area: {circle.calculateAerea()}");
                    Console.WriteLine("-------------------------");
                }
                else if (shape is Rectangle rectangle)
                {
                    Console.WriteLine($"Name: {rectangle._Name}\n" +
                                      $"Colour: {rectangle._Colour}\n" +
                                      $"Lenght: {rectangle._Length}\n" +
                                      $"Width: {rectangle._Width}\n" +
                                      $"Area: {rectangle.calculateAerea()}");
                    Console.WriteLine("-------------------------");
                }
                else if (shape is Triangle triangle)
                {
                    Console.WriteLine($"Name: {triangle._Name}\n" +
                                      $"Colour: {triangle._Colour}\n" +
                                      $"Height: {triangle._Height}\n" +
                                      $"Base: {triangle._TriangleBase}\n" +
                                      $"Area: {triangle.calculateAerea()}");
                    Console.WriteLine("-------------------------");
                }
            }

            Console.WriteLine($"Total Area: {calculateTotalArea()}");

            // sortList();
            // filterColours();
            // filterColourTwo();
        }

        public void mainMenu()
        {

            while (true)
            {
                Console.WriteLine("[1] List all info\n" +
                                  "[2] Calculate total areal\n" +
                                  "[3] Sort list\n" +
                                  "[4] Filter by colour 1.0\n" +
                                  "[5] Filter by colour 2.0\n" +
                                  "[0] Quit");

                int input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 0:
                        return;
                    case 1:
                        printInfo();
                        break;
                    case 2:
                        Console.WriteLine(calculateTotalArea());
                        break;
                    case 3:
                        sortList();
                        break;
                    case 4:
                        filterColours();
                        break;
                    case 5:
                        filterColourTwo();
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }
            }
        }
    }
}
