using DyrClass;

namespace IOClass {

    class InOut {

        public string name, art;
        public int age;

        List<Dyr> ListeMedDyr = new List<Dyr> {
            new Dyr("Per", "Kanin", 123),
            new Dyr("Pål", "hund", 234),
            new Dyr("Espen", "katt", 1345)
        };




        private void addAnimal() {
            Console.WriteLine("Add aminals");

            Console.WriteLine("Add Name for the animal");

            name = Console.ReadLine();

            Console.WriteLine("Add art for the animal");

            art = Console.ReadLine();

            Console.WriteLine("Add age for the animal");

            age = Convert.ToInt32(Console.ReadLine());

            ListeMedDyr.Add(new Dyr(name, art, age));
        }


        private void printDyr() {
            foreach (Dyr dyr in ListeMedDyr) {
                Console.WriteLine($"Name: {dyr.Name} Art: {dyr.Art} Age: {dyr.Age}");
            }
        }

        private void searchAnimal() {
            Console.WriteLine("Searc for a animal");

            string y = Console.ReadLine();

            foreach (Dyr dyr in ListeMedDyr) {
                if (y == dyr.Art) {
                Console.WriteLine($"Name: {dyr.Name} Art: {dyr.Art} Age: {dyr.Age}");
                }
            }
            
        }

        public void menu() {

            while (true) {
                Console.WriteLine("Dyre Hagen");

                Console.WriteLine("1. Add animal\n2. Print animal\n3. Seach");

                int x = Convert.ToInt32(Console.ReadLine());

                switch(x) {
                    case 1:
                        addAnimal();
                        break;
                    case 2:
                        printDyr();
                        break;
                    case 3:
                        searchAnimal();
                        break;
                    default:
                        break;
                }


            }
        }
        
    }
    
}


