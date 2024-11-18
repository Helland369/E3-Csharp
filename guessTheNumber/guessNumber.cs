using System;

namespace guessNumber {


    class Number {

        static Random rand = new Random();

        public void PrintRand() {

            int num = rand.Next(0, 100);

            bool condition = true;

            
           while (condition == true) {

                Console.WriteLine("Guess the number! \n A nuber between 1 and 100");
                int input = Convert.ToInt32(Console.ReadLine());

                if (input == num)
                {
                    Console.WriteLine("Correct!");
                    Console.WriteLine("Would you like to play again? Y/N");
                    char playAgian = Convert.ToChar(Console.ReadLine().ToLower());

                    if (playAgian == 'y') {
                        PrintRand();
                    } else if (playAgian == 'n') {
                        Environment.Exit(0);
                    } else {
                        Console.WriteLine("Wrong input!");
                    }
                }
                else if (input < num)
                {
                    Console.WriteLine("The number you guessed is too low!");
                }
                else if (input > num)
                {
                    Console.WriteLine("The number you guessed is too high!");
                }
                else
                {
                    Console.WriteLine("Incorect input! Gusee a number between 1 and 100");
                }
            }
        }
    }
}
