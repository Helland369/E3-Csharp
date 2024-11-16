namespace crocodile
{

    class Croc
    {

        int points;

        static Random rand = new Random();

        public void crocGame() {

            while (true) {

                int randX = rand.Next(0, 11);
                int randY = rand.Next(0, 11);


                string input;

                Console.WriteLine($"{randX}");
                Console.WriteLine($"{randY}");
                input = Console.ReadLine();

                if (input == "<" && randX < randY) {
                    Console.WriteLine($"Correct! You now have {points} points");
                    points++;
                } else if (input == ">" && randX > randY) {
                    Console.WriteLine($"Correct! You now have {points} points");
                    points++;
                } else if (input == "=" && randX == randY) {
                    Console.WriteLine($"Correct! You now have {points} points");
                    points++;
                } else if (input == "<" || input == ">" || input == "=") {
                    Console.WriteLine($"Wrong asnwer :( | You now have {points} points");
                    points--;
                } else {
                    Console.WriteLine("Invalid input! Exiting program...");
                    break;
                }
            }
        }
    }
}
