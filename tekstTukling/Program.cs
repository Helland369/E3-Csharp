using rotateText;
using changeWord;

class Program {

    static int x;

    static void Main() {
        RotateTxt rottxt = new RotateTxt();
        WordChange wc = new WordChange();

        do {

            Console.WriteLine("\n1. Change the word");
            Console.WriteLine("2. Rotate the text");
            x = Convert.ToInt32(Console.ReadLine());

            switch (x) {
                case 1:
                    wc.changeTheWord();
                    break;
                case 2:
                    rottxt.rotate();
                    break;
                default:
                    Console.WriteLine("Wrong input!");
                    break;
            }

        } while (x != 0);

    }
}
