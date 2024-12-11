namespace Abaxrekruttering
{


    class Boat : Vehicles
    {
        private int topSpeed;
        private double grossTonnage;

        public Boat(int kiloWatt, int topSpeed, double grossTonnage, string hallmark, string type) : base(kiloWatt, hallmark, type)
        {
            this.topSpeed = topSpeed;
            this.grossTonnage = grossTonnage;
        }

        public override void printInfo()
        {
            Console.WriteLine("Boat: \n" +
                              $"Top speed: {topSpeed} knop\n" +
                              $"Gross tonnage: {grossTonnage} tonn\n" +
                              $"Effect: {_kiloWatt} Kw\n" +
                              $"Hallmark: {_hallmark}\n" +
                              $"Type: {_type}\n");
        }
    }
}
