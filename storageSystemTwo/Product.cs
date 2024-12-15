namespace StorageSystemTwo {


    abstract class Product {
        protected double _price;
        protected string _name;

        public Product(double price, string name) {
            this._price = price;
            this._name = name;
        }

        public double getPrice() {
            return _price;
        }

        public string getName() {
            return _name;
        }
        
        public abstract void printInfo();
    }
}
