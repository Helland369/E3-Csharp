using vehicles;


namespace CarClass
{

    class Car : Ivehicles
    {
        public string _brand { get; set; }
        public string _type { get; set; }
        public string _registrationNumber { get; set; }

        public Car(string brand, string type, string regNum) {
            this._brand = brand;
            this._type = type;
            this._registrationNumber = regNum;
        }
        
        public void Drive()
        {
            Console.WriteLine("The car drives");
        }
    }
}
