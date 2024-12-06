using GameClicker;


class Program
{

    static void Main() {

        ClickerGame game = new ClickerGame();

        Commands cmd = new Commands(game);

        while (true) {
            Console.Clear();
            Console.WriteLine($"Points: {game._Points}\nPoints per click: {game._PointsPerClick}\nPoints increase: {game._PointsPerClickIncrease}");
            Console.WriteLine("Command List:" +
                              "Press: [SPACE] to click" +
                              "Press: [u] to uppgrade | Cost: 10 points" +
                              "Press: [s] for super uppgrade | Cost: 100 points" +
                              "Press: [q] to quit");
            var command = Console.ReadKey().KeyChar;
            cmd.run(command);
        }
    }
}



// static void Main()
// {
//     ClickerGame gc = new ClickerGame();

//     while (true)
//     {

//         Console.WriteLine($"Points: {gc._Points}");

//         Console.WriteLine("1. click\n2. upgrade 3. super");

//         int x = Convert.ToInt32(Console.ReadLine());

//         switch (x)
//         {
//             case 1:
//                 gc.click();
//                 break;
//             case 2:
//                 gc.upgrade();
//                 break;
//             case 3:
//                 gc.superUpgrade();
//                 break;
//         }
//     }
// }
