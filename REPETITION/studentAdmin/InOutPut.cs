using System.Runtime.CompilerServices;

namespace StudentAdmin {


    class InOutPut {

        int input;

        private static Subject _subject1 = new Subject("GPROG1", "General Programming", 15);
        private static Subject _subject2 = new Subject("ASM1", "Programming in Assembly", 25);
        private static Subject _subject3 = new Subject("BIO1", "Biology", 18);
        private static Subject _subject4 = new Subject("PHI1", "Philosophy", 20);
        
        private List<Student> _students = new List<Student>
        {
            new Student("Per","Programming",25,123123, 
                new List<Subject> { _subject1, _subject2 }, new List<Grade> { new Grade(6, _subject1), new Grade(4, _subject2)}),
            new Student("Pål","Biology",33,213213,
                new List<Subject> {_subject3, _subject1}, new List<Grade> {new Grade(5, _subject3), new Grade(4, _subject1)}),
            new Student("Per","Philosophy",22,321321,
                new List<Subject> {_subject4, _subject1}, new List<Grade> {new Grade(6, _subject4), new Grade(3, _subject1)}),
        };

        public InOutPut() {
            MainMenu();
        }

        private void PrintStudentList()
        {
            foreach(Student student in _students) {
                student.PrintStudentInfo();
                Console.WriteLine($"Total study points: {student.TotalStudyPoints()}\n" +
                                  $"Average grade: {student.AverageGrade()}\n");
                if (student.Grades.Count > 0)
                {
                    foreach (Grade grade in student.Grades)
                    {
                        Console.WriteLine($"Grade: {grade.Subject.SubjectName}\n" +
                                          $"Subject: {grade.Subject.SubjectCode}\n" +
                                          $"Student: {grade.Subject.StudyPoints}\n");
                    }
                }
                else if (student.Subjects.Count > 0)
                {
                    foreach (Subject subject in student.Subjects)
                    {
                        Console.WriteLine($"Subject: {subject.SubjectCode}\n" +
                                          $"Subject name: {subject.SubjectName}\n" +
                                          $"Study points: {subject.StudyPoints}\n");
                    } 
                }
            }
        }

        public void MainMenu() {

            while (true) {
                Console.WriteLine("[1] View all the students\n" +
                                  "[0] Exit\n");

                input = Convert.ToInt32(Console.ReadLine());

                switch (input) {
                    case 0:
                        return;
                    case 1:
                        PrintStudentList();
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        }
    }
}
