namespace storageSystem
{


    class Electronics : IProduct
    {

        public string name { get; set; }
        public double price { get; set; }
        public int productNum { get; set; }
        public int plu { get; set; }

        public string warranty { get; set; }

        public Electronics(string name, double price, int productNum, int plu, string warranty)
        {
            this.name = name;
            this.price = price;
            this.productNum = productNum;
            this.plu = plu;
            this.warranty = warranty;
        }

        public void printInfo()
        {
            Console.WriteLine($"Name: {this.name}\n" +
                              $"Price: {this.price}\n" +
                              $"Product number: {this.productNum}\n" +
                              $"Plu: {this.plu}\n" +
                              $"Warranty: {this.warranty}\n");
            Console.WriteLine("----------------------------------------");
        }
    }
}
