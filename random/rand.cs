using System;

namespace doRand {

    class RandomHobby {

        static string[] hobby = { "Linux", "Emacs", "Programming", "Making food", "Reading Books" };

        static Random rand = new Random();
        int randNum = rand.Next(0, hobby.Length);

        public void RandHoddy() {

            Console.WriteLine("Who would like a new hobby? \"Enter your name!\"");
            string name = Console.ReadLine();

            if (randNum == 0) {
                    Console.WriteLine($"{name}'s new hobby is {hobby[randNum]}");
            }
            else if (randNum == 1) {
                    Console.WriteLine($"{name}'s new hobby is {hobby[randNum]}");
            }
            else if (randNum == 2) {
                    Console.WriteLine($"{name}'s new hobby is {hobby[randNum]}");
            }
            else if (randNum == 3) {
                    Console.WriteLine($"{name}'s new hobby is {hobby[randNum]}");
            }
            else if (randNum == 4) {
                    Console.WriteLine($"{name}'s new hobby is {hobby[randNum]}");
            }
            else if (randNum == 5) {
                    Console.WriteLine($"{name}'s new hobby is {hobby[randNum]}");
            } else {
                    Console.WriteLine("No hobby :(");
            }
        }

    }
    
}
