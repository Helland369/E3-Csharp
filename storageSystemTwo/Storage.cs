namespace StorageSystemTwo {


    class Storage {

        private double inputPrice;
        private string inputName, inputAdditionalText;

        private List<Product> productList = new List<Product> {
            new Electronics(1339.49,"16GB Memmory","30 days money back guarantee"),
            new Electronics(4600.99,"AMD CPU","30 days money back guarantee"),
            new Electronics(3436.66,"Mother board","30 days money back guarantee"),
            new Clothes(399.99, "T-Shirt","L"),
            new Clothes(678.33, "Sweater","XXL"),
            new Clothes(1200.99, "Pants","L"),
            new Food(12.99,"Apple","20.12.24"),
            new Food(16.50,"Banana","23.12.24"),
            new Food(200.66,"Salami","26.05.25"),
        };

        private void listAllProducts() {
            foreach(Product product in productList) {
                if (product is Electronics el) {
                    el.printInfo();
                }
                else if (product is Clothes cl) {
                    cl.printInfo();
                }
                else if (product is Food food) {
                    food.printInfo();
                }
            }
        }

        private double addProductPrice(string itemName) {
            Console.WriteLine($"Add a price for the {itemName} item");
            inputPrice = Convert.ToInt32(Console.ReadLine());
            return inputPrice;
        }

        private string addProductName(string itemName) {
            Console.WriteLine($"Add a name for {itemName} item");
            inputName = Console.ReadLine();
            return inputName;
        }
        
        private string addProductAditionalText(string itemName, string additionalText) {
            Console.WriteLine($"Add {additionalText} for the {itemName} item");
            inputAdditionalText = Console.ReadLine();
            return inputAdditionalText;
        }
        
        private void addProduct() {
            Console.WriteLine("[1] Add a food item\n" +
                              "[2] Add a Clothes item\n" +
                              "[3] Add a Electronics item\n" +
                              "[0] Exit");
            int usrInput = Convert.ToInt32(Console.ReadLine());

                switch (usrInput) {
                    case 0:
                        return;
                    case 1:
                        //addProductPrice("food");
                        //addProductName("food");
                        //addProductAditionalText("food","expiration date");
                        productList.Add(new Food(addProductPrice("food"),addProductName("food"),addProductAditionalText("food","expiration date")));
                        break;
                    case 2:
                        //addProductPrice("clothes");
                        //addProductName("clothes");
                        //addProductAditionalText("clothes","size");
                        productList.Add(new Clothes(addProductPrice("clothes"),addProductName("clothes"),addProductAditionalText("clothes","size")));
                        break;
                    case 3:
                        //addProductPrice("electronics");
                        //addProductName("electronics");
                        //addProductAditionalText("electronics","warranty");
                        productList.Add(new Electronics(addProductPrice("electronics"), addProductName("electronics"),addProductAditionalText("electronics","warranty")));
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
        }

        private void removeProduct() {

            int i = 0;

            foreach (Product product in productList)
            {
                if (product is Electronics el)
                {
                    Console.WriteLine($"Index: [{i}]");
                    el.printInfo();
                }
                else if (product is Clothes clothes)
                {
                    Console.WriteLine($"Index: [{i}]");
                    clothes.printInfo();
                }
                else if (product is Food food)
                {
                    Console.WriteLine($"Index: [{i}]");
                    food.printInfo();
                }
                i++;
            }

            Console.WriteLine("Write the INDEX of the item you want to delete");

                string indexIn = Console.ReadLine();

                int indexInt = Convert.ToInt32(indexIn);

                productList.RemoveAt(indexInt);
        }

        public void mainMenu() {

            while (true) {
                
            Console.WriteLine("*** Welcome to the storage system 2.0 ***");

                Console.WriteLine("[1] View the product list\n" +
                                  "[2] Add item to the product list\n" +
                                  "[3] Remove item form the product list\n" +
                                  "[0] Exit");

                int menuInput = Convert.ToInt32(Console.ReadLine());

                switch (menuInput) {
                    case 0:
                        return;
                    case 1:
                        listAllProducts();
                        break;
                    case 2:
                        addProduct();
                        break;
                    case 3:
                        removeProduct();
                        break;
                    default:
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
