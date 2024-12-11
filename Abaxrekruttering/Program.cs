namespace Abaxrekruttering {


    class Program {

        static void Main() {
            Car car1 = new Car(147, 200, "NF123456", "Light Vehicle", "Green");
            Car car2 = new Car(150, 195, "NF654321", "Light Vehicle", "Blue");
            Airplane plane = new Airplane(1000, 30, 2, 10, "LN1234", "Jett");
            Boat boat = new Boat(100, 30, 0.5, "ABC123", "Small boat");

            car1.printInfo();
            car2.printInfo();
            plane.printInfo();
            plane.fly();
            car1.drive(1);
            boat.printInfo();

        }
    }
}
    
