using forTheLoop;
using forSaanSkalDetBli;
using whileTrue;

class Program {


    static void Main() {

        int x;

        ForLoop forloop = new ForLoop();
        ForEachLoop foreloop = new ForEachLoop();
        WhileLoop loop = new WhileLoop();

        do {

            Console.WriteLine("1. For loop");
            Console.WriteLine("2. Foreach loop");
            Console.WriteLine("3. Whiel loop");
            x = Convert.ToInt32(Console.ReadLine());

            switch (x) {
                case 1:
                    forloop.forStr();
                    break;
                case 2:
                    foreloop.forStrLoop();
                    break;
                case 3:
                    loop.loopWhile();
                    break;
                default:
                    break;
            }
        } while (x != 0);
    }
}
