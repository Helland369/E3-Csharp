using _Subject_;
using _Grade_;

namespace _Student_ {


    class Student {

        public string name { get; set; }
        public string program { get; set; }
        public int age { get; set; }
        public int id { get; set; }

        public List<Subject> subjects { get; set; } = new List<Subject>();
        public List<Grade> grades { get; set; } = new List<Grade>();

        public Student(string name, string program, int age, int id) {

            this.name = name;
            this.program = program;
            this.age = age;
            this.id = id;
        }

        public double gradeAverage() {
            // lambda g = grade // g is on grade at the time
            return grades.Average(g => g.gradeValue);
        }

        public double studyPointsTot() {
            // lambda s = subject // s is a studyPoint at the time
            return subjects.Sum(s => s.studyPoints);
        }
        
        public void printStudentInfo() {

            Console.WriteLine($"Name: {this.name} | Program: {this.program} | Age: {this.age} | ID: {this.id}");
            Console.WriteLine("-------------------------------------------------------------------------------------");
        }
    }
}
