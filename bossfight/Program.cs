using _GameCharacter_;


class Program {

    static void Main() {

        GameCharacter player = new GameCharacter("Player1", 100,20,40);
        GameCharacter boss = new GameCharacter("Boss", 500,40);
        
        while (player.isAlive() && boss.isAlive()) 
        {
            Random rand = new Random();
            int x = rand.Next(0,30);
            boss.strength = x;

            Console.WriteLine($"Player: {player.name}|\t|Boss: {boss.name}");
            Console.WriteLine($"HP: {player.hitPoint}|\t\t|HP: {boss.hitPoint}");
            Console.WriteLine($"Strength: {player.strength}|\t\t|Strength: {boss.strength}");
            Console.WriteLine($"Stamina: {player.stamina}|\t\t|Stamina: {boss.stamina}");

            Console.WriteLine("1. Attack\n2. Recharge\n3. Heal");
            int y = Convert.ToInt32(Console.ReadLine());

            switch (y) {

                case 1:
                    player.fight(boss);
                    break;
                case 2:
                    player.recharge();
                    break;
                case 3:
                    player.heal();
                    break;
                default:
                    Console.WriteLine("Ivalid option");
                    break;
            }
        }
    }
}
