namespace list {


    class Person
    {

        public string name { get; set; }
        public int age { get; set; }
        public string city { get; set; }

        public Person(string name, int age, string city) {

            this.name = name;
            this.age = age;
            this.city = city;
        }

        public Person() {} // not ideal... but it works :D

        public void makeList() {

            List<Person> people = new List<Person>();

            Person p1 = new Person("Ola", 56, "Oslo");
            Person p2 = new Person("Gunnar", 32, "Fredrikstad");
            Person p3 = new Person("Sara", 23, "Moss");

            people.Add(p1);
            people.Add(p2);
            people.Add(p3);

            foreach (Person person in people) {

                Console.WriteLine($"Name: {person.name} age: {person.age} city: {person.city}");
            }
        }

        public void makeListTwo() {

            List<Person> morePeople = new List<Person> {

                new Person("Hans", 33,"Lier"),
                new Person("Jon", 75, "Hardanger"),
                new Person("Olga", 20, "Lærdal")
            };

            foreach (Person person in morePeople) {

                Console.WriteLine($"Name: {person.name} age: {person.age} city: {person.city}");
            }
        }
    }
}


