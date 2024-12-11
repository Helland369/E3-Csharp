namespace Abaxrekruttering
{


    internal class Car : Vehicles
    {

        private int _topSpeed;
        private string _colour;

        public Car(int kilowatt, int topSpeed, string hallmark, string type, string colour) : base(kilowatt, hallmark, type)
        {
            this._topSpeed = topSpeed;
            this._colour = colour;
        }

        public override void printInfo()
        {
            Console.WriteLine($"Car:\n" +
                              $"Top speed: {_topSpeed} km/h\n" +
                              $"Colour: {_colour}\n" +
                              $"Effect: {_kiloWatt} Kw\n" +
                              $"Hallmark: {_hallmark}\n" +
                              $"Type: {_type}\n");
        }

        public void drive(int car)
        {
            Console.WriteLine($"Car {car}: is driving...\n" +
                              "Car sounds...\n");
        }

    }
}
