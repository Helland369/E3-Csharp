namespace pokemon {


class Pokemon {

    public string name { get; set; }
    public int hp { get; set; }
    public int level { get; set; }

    // over loading
    public Pokemon(string name) {
            this.name = name;
    }

    public Pokemon(string name, int level) {
            this.name = name;
            this.level = level;
    }
    
    public Pokemon(string name, int hp, int level) {

        this.name = name;
        this.hp = hp;
        this.level = level;
    }
}


}


