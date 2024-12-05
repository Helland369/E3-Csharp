using vehicles;


namespace BoatClass
{


    class Boat : Ivehicles
    {
        public string _brand { get; set; }
        public string _type { get; set; }
        public string _registrationNumber { get; set; }

        public Boat(string brand, string type, string regNum)
        {
            this._brand = brand;
            this._type = type;
            this._registrationNumber = regNum;
        }

        public void Drive()
        {
            Console.WriteLine("The boat drives");
        }

    }


}


