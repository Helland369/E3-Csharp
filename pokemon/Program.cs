using pokemon;


class Program {

    static void Main() {

        Pokemon pikachu = new Pokemon("Pikachu", 30, 40);
        Pokemon bulbasaur = new Pokemon("bulbasaur", 35, 18);
        Pokemon eve = new Pokemon("Eve", 16, 5);
        Pokemon p2 = new Pokemon("One pokemon");
        Pokemon p3 = new Pokemon("Two pokemon", 50);

        Console.WriteLine($"You fonud {pikachu.name} it has {pikachu.hp} hp and is level {pikachu.level}");
        Console.WriteLine($"You found {bulbasaur.name} it has {bulbasaur.hp} hp and is level {bulbasaur.level}");
        Console.WriteLine($"You found {eve.name} it has {eve.hp} hp and is level {eve.level}");
        Console.WriteLine($"You found a overloaded pokemon {p2.name}");
        Console.WriteLine($"You found a nother over loaded pokemon {p3.name} {p3.level}");
    }
}

