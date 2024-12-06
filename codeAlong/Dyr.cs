namespace DyrClass {


    class Dyr {
        private string name, art;
        private int age;

        public Dyr(string name, string art, int age) {
            this.name = name;
            this.art = art;
            this.age = age;
        }

        public string Name {
            get { return name; }
            set { this.name = value; }
        }

        public string Art {
            get { return art; }
            set { art = value; }
        }

        public int Age {
            get { return age; }
            set { this.age = value; }
        }
    }
    
}
