using CarClass;
using BoatClass;
using vehicles;


class Program {

    static void Main() {

        List<Ivehicles> vehicles = new List<Ivehicles>() {
            new Car("BMW","Sedan","123123"),
            new Car("VW","Station wagon","321321"),
            new Boat("Some boat brand","Yatch","67756"),
            new Boat("Some boat brand","Sail boat","987987"),
        };


        foreach(Ivehicles vh in vehicles) {
            Console.WriteLine($"Brand: {vh._brand} Type {vh._type} Registration number: {vh._registrationNumber}");
        }
    }
}
