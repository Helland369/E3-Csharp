namespace _Subject_ {


    class Subject {

        public string subjectCode { get; set; }
        public string subjectName { get; set; }
        public double studyPoints { get; set; }

        public Subject(string subjectCode, string subjectName, double studyPoints) {

            this.subjectCode = subjectCode;
            this.subjectName = subjectName;
            this.studyPoints = studyPoints;
        }

        public void printSubjectInfo() {

            Console.WriteLine($"Subject code: {this.subjectCode} | Subject name: {this.subjectName} | Study points: {this.studyPoints}");
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
        }
    }
}
