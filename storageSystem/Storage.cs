namespace storageSystem
{


    class Storage
    {

        private string _name = "";
        private double _price;
        private int _productNum;
        private int _plu;
        private string _additionalInfo = "";
        private int choice;

        private List<IProduct> products = new List<IProduct> {
            new Food("Apple",12.63,349913,333,"26.dec.2024"),
            new Food("Steak",123.66,57443,555,"27.dec.2024"),
            new Food("Bread",66.99,88346,444,"18.dec.2024"),
            new Clothes("T-shrt",100.33,75887,222,"L"),
            new Clothes("Pants",600.72,941175,233,"XXL"),
            new Clothes("Shirt",300.66,54187,643,"S"),
            new Electronics("GPU",6900.99,69033,690,"30 day money back guarantee"),
            new Electronics("CPU",4689.66,09063,090,"30 day money back guarantee"),
            new Electronics("Mother board",3379.89,753921,999,"30 day money back guarantee"),
            new Electronics("Laptop",25300.76,789432,1010,"30 day money back guarantee"),
        };

        public void addFood()
        {
            Console.WriteLine("Add a food item to the list");

            Console.Write("Write name of food item\n");
            _name = Console.ReadLine();

            Console.Write("Write price of food item\n");
            _price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Write product number of food item\n");
            _productNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Write PLU code for food item\n");
            _plu = Convert.ToInt32(Console.ReadLine());

            Console.Write("Write expiration date for food item");
            _additionalInfo = Console.ReadLine();

            this.products.Add(new Food(_name, _price, _productNum, _plu, _additionalInfo));
        }

        public void addClothes()
        {
            Console.WriteLine("Add a clothes item to the list");

            Console.Write("Write name of clothes item\n");
            _name = Console.ReadLine();

            Console.Write("Write price of clothes item\n");
            _price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Write product number of clothes item\n");
            _productNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Write PLU code for clothes item\n");
            _plu = Convert.ToInt32(Console.ReadLine());

            Console.Write("Write the size of the clothes item");
            _additionalInfo = Console.ReadLine();

            this.products.Add(new Clothes(_name, _price, _productNum, _plu, _additionalInfo));
        }

        public void addElectronics()
        {
            Console.WriteLine("Add a electronics item to the list");

            Console.Write("Write name of electronics item\n");
            _name = Console.ReadLine();

            Console.Write("Write price of electronics item\n");
            _price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Write product number of electronics item\n");
            _productNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Write PLU code for electronics item\n");
            _plu = Convert.ToInt32(Console.ReadLine());

            Console.Write("Write the warranty for the electronics item");
            _additionalInfo = Console.ReadLine();

            this.products.Add(new Electronics(_name, _price, _productNum, _plu, _additionalInfo));
        }

        // public void addItem()
        // {

        //     //while (choice != 0)
        //     //{
        //         Console.WriteLine("### Choose the item you want to add ###");

        //         Console.WriteLine("[1] Add food\n[2] Add clothes\n[3] Add Electronics");

        //         switch (choice)
        //         {
        //             case 0:
        //                 return;
        //                 break;
        //             case 1:
        //                 addFood();
        //                 break;
        //             case 2:
        //                 addClothes();
        //                 break;
        //             case 3:
        //                 addElectronics();
        //                 break;
        //             default:
        //                 Console.WriteLine("Invalid input!!");
        //                 break;
        //         }
        //         //}
        // }

        public void removeItem()
        {
            //int i = 0;

            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"Name: {products[i].name}\n" +
                                  $"Price: {products[i].price}\n" +
                                  $"Product number: {products[i].productNum}\n" +
                                  $"PLU: {products[i].plu}\n");
            }

            Console.WriteLine("Write the PLU code of the item you want to delet");

            var choise = Convert.ToInt32(Console.ReadLine());
            // string choise = Console.ReadLine();

            var index = products.FindIndex(p => p.plu == choice);

            if (index > 0)
            {
                products.RemoveAt(index);
            }

            //products.Remove(choice);

            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"Name: {products[i].name}\n" +
                                  $"Price: {products[i].price}\n" +
                                  $"Product number: {products[i].productNum}\n" +
                                  $"PLU: {products[i].plu}\n");
            }
        }

        public void printListItems()
        {
            foreach (IProduct product in products)
            {

                if (product is Food food)
                {
                    food.printInfo();
                }
                else if (product is Clothes clothes)
                {
                    clothes.printInfo();
                }
                else if (product is Electronics el)
                {
                    el.printInfo();
                }
            }
        }
    }
}
