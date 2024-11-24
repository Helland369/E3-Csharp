using _Student_;
using _Grade_;
using _Subject_;


class Program {

    static void Main() {

        Student student1 = new Student("Per","General Programming",36,1);
        Student student2 = new Student("Pål","General Programming",42,2);
        Student student3 = new Student("Espen","General Programming",23,3);

        // List<Subject> subjects = new List<Subject>();

        Subject subject1 = new Subject("PROG101","General programmin", 26.33);
        Subject subject2 = new Subject("Csharp1101","C#", 22.99);
        Subject subject3 = new Subject("CPP0101","C++", 23.66);
        Subject subject4 = new Subject("JS101", "JavaScript", 16.3);

        student1.subjects.AddRange(new List<Subject> {subject1, subject2});
        student2.subjects.AddRange(new List<Subject> {subject1, subject3});
        student3.subjects.AddRange(new List<Subject> {subject1, subject4});

        Grade grade1 = new Grade(5, student1,subject1);
        Grade grade2 = new Grade(3, student1,subject2);

        Grade grade3 = new Grade(2, student2,subject1);
        Grade grade4 = new Grade(4, student2,subject3);

        Grade grade5 = new Grade(3,student3,subject1);
        Grade grade6 = new Grade(5,student3,subject4);

        student1.grades.AddRange(new List<Grade> { grade1, grade2 });
        student2.grades.AddRange(new List<Grade> { grade3, grade4 });
        student3.grades.AddRange(new List<Grade> { grade5, grade6 });

        student1.printStudentInfo();
        student2.printStudentInfo();
        student3.printStudentInfo();

        grade1.gradePrintInfo();
        grade2.gradePrintInfo();
        grade3.gradePrintInfo();
        grade4.gradePrintInfo();
        grade5.gradePrintInfo();
        grade6.gradePrintInfo();

        subject1.printSubjectInfo();
        subject2.printSubjectInfo();
        subject3.printSubjectInfo();
        subject4.printSubjectInfo();

        Console.WriteLine($"Name: {student1.name} | Grade average: {student1.gradeAverage()} | Study pints: {student1.studyPointsTot()}");
        Console.WriteLine($"Name: {student2.name} | Grade average: {student2.gradeAverage()} | Study pints: {student2.studyPointsTot()}");
        Console.WriteLine($"Name: {student3.name} | Grade average: {student3.gradeAverage()} | Study pints: {student3.studyPointsTot()}");
    }
}
