namespace StorageSystemTwo {


    class Food : Product {

        private string _expirationDate;

        public Food(double price, string name, string expirationDate) : base(price, name)
        {
            this._expirationDate = expirationDate;
        }

        public string getExpirationDate() {
            return _expirationDate;
        }

        public override void printInfo()
        {
            Console.WriteLine($"Name: {_name}\n" +
                              $"Price: {_price}\n" +
                              $"Expiration date: {_expirationDate}\n");
        }
    }
}
