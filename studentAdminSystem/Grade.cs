using _Student_;
using _Subject_;

namespace _Grade_ {


    class Grade {

        public double gradeValue { get; set; }
        // Reference
        public Student student { get; set; }
        public Subject subject { get; set; }

        public Grade(double gradeValue, Student student, Subject subject) {

            this.student = student;
            this.subject = subject;
            this.gradeValue = gradeValue;
        }

        public void gradePrintInfo() {

            Console.WriteLine($"Student name: {student.name} | Subject: {subject.subjectName} | Grade: {this.gradeValue}");
            Console.WriteLine("-------------------------------------------------------------------------------------");
        }
    }
}
