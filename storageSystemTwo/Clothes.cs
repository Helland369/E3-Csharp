namespace StorageSystemTwo {


    class Clothes : Product {

        private string _size;

        public Clothes(double price, string name, string size) : base(price, name)
        {
            this._size = size;
        }

        public string getSize() {
            return _size;
        }

        public override void printInfo()
        {
            Console.WriteLine($"Name: {_name}\n" +
                              $"Price: {_price}\n" +
                              $"Size: {_size}\n");
        }
    }
}
