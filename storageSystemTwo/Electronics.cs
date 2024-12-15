namespace StorageSystemTwo {


    class Electronics : Product {

        private string _warranty;

        public Electronics(double price, string name, string warranty) : base(price, name)
        {
            this._warranty = warranty;
        }

        public string getWarranty() {
            return _warranty;
        }
        
        public override void printInfo()
        {
            Console.WriteLine($"Name: {_name}\n" +
                              $"Price: {_price}\n" +
                              $"Warranty: {_warranty}\n");
        }
    }
}
