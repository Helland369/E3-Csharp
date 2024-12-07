namespace storageSystem
{


    interface IProduct
    {

        public string name { get; set; }
        public double price { get; set; }
        public int productNum { get; set; }
        public int plu { get; set; }

        public void printInfo();
    }
}


