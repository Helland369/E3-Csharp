namespace storageSystem
{


    class Food : IProduct
    {

        public string name { get; set; }
        public double price { get; set; }
        public int productNum { get; set; }
        public int plu { get; set; }

        public string expirationDate { get; set; }

        public Food(string name, double price, int productNum, int plu, string expDate)
        {
            this.name = name;
            this.price = price;
            this.productNum = productNum;
            this.plu = plu;
            this.expirationDate = expDate;
        }

        public void printInfo()
        {
            Console.WriteLine($"Name: {this.name}\n" +
                              $"Price: {this.price}\n" +
                              $"Product number: {this.productNum}\n" +
                              $"Plu: {this.plu}\n" +
                              $"Expiration date: {this.expirationDate}");
            Console.WriteLine("----------------------------------------");
        }
    }
}
