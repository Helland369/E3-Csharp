namespace Abaxrekruttering
{


    internal class Airplane : Vehicles
    {
        private int wingspan, loadCapacity, planeWeight;

        public Airplane(int kiloWatt, int wingspan, int loadCapacity, int planeWeight, string hallmark, string type) : base(kiloWatt, hallmark, type)
        {
            this.wingspan = wingspan;
            this.loadCapacity = loadCapacity;
            this.planeWeight = planeWeight;
        }

        public override void printInfo()
        {
            Console.WriteLine($"Plane: \n" +
                              $"Wingspan: {wingspan} m\n" +
                              $"Load capacity: {loadCapacity} tonn\n" +
                              $"Plane weight: {planeWeight} tonn\n" +
                              $"Effect {_kiloWatt} Kw\n" +
                              $"Hallmark: {_hallmark}\n" +
                              $"Type: {_type}\n");
        }

        public void fly()
        {
            Console.WriteLine("The air plane flyes away...\n" +
                              "Air plane sounds...\n");
        }
    }
}
