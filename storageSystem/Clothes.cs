namespace storageSystem
{


    class Clothes : IProduct
    {

        public string name { get; set; }
        public double price { get; set; }
        public int productNum { get; set; }
        public int plu { get; set; }

        public string size { get; set; }

        public Clothes(string name, double price, int productNum, int plu, string size)
        {
            this.name = name;
            this.price = price;
            this.productNum = productNum;
            this.plu = plu;
            this.size = size;
        }

        public void printInfo()
        {
            Console.WriteLine($"Name: {this.name}\n" +
                              $"Price: {this.price}\n" +
                              $"Product number: {this.productNum}\n" +
                              $"Plu: {this.plu}\n" +
                              $"Size: {this.size}");
            Console.WriteLine("----------------------------------------");
        }
    }
}
