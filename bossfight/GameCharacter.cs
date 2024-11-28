namespace _GameCharacter_ {


    class GameCharacter {
        public string name { get; set; }
        public int hitPoint { get; set; }
        public int strength { get; set; }
        public int stamina { get; set; }

        public GameCharacter(string name, int hp, int strength, int stamina) {
            this.name = name;
            this.hitPoint = hp;
            this.strength = strength;
            this.stamina = stamina;
        }

        public GameCharacter(string name, int hp, int stamina) {
            this.name = name;
            this.hitPoint = hp;
            this.stamina = stamina;
        }

        public void fight(GameCharacter target) {
            if (hitPoint > 1 || stamina > 1) {
                target.hitPoint = target.hitPoint - strength;
                stamina = stamina - 10;
                Console.WriteLine($"{name} hits {target.name} for {strength} damage and has {hitPoint} hp left");
                if (target.hitPoint > 1) {
                    hitPoint = hitPoint - target.strength;
                    Console.WriteLine($"{target.name} hits {name} for {target.strength} damage and has {target.hitPoint} hp left");
                }
            } else if (stamina <= 1) {
                Console.WriteLine("You need to recharge stamina");
            }
        }

        public int recharge() {
            if (stamina <= 30)
            stamina = stamina + 10;
            return stamina;
        }

        public int heal() {
            if (hitPoint < 100)
                hitPoint = hitPoint + 10;
            return hitPoint;
        }

        public bool isAlive() {
            return hitPoint > 0;
        }
    }
}
