namespace StudentAdmin
{


    class Student
    {

        private int _age, _studentID;
        private string _name, _studyProgram;

        private List<Subject> _subjects;
        private List<Grade> _grades;

        public Student(string name, string studyProgram, int age, int studentId, List<Subject> subjects, List<Grade> grades)
        {
            _name = name;
            _studyProgram = studyProgram;
            _age = age;
            _studentID = studentId;
            _subjects = subjects;
            _grades = grades;
        }

        public int Age { get { return _age; } set { _age = value; } }
        public int StudentID { get { return _studentID; } set { _studentID = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string StudyProgram { get { return _studyProgram; } set { _studyProgram = value; } }
        public List<Subject> Subjects { get { return _subjects; } set { _subjects = value; } }
        public List<Grade> Grades { get { return _grades; } set { _grades = value; } }

        public void PrintStudentInfo()
        {
            Console.WriteLine("Student info\n" +
                              $"Name: {_name}\n" +
                              $"Age: {_age}\n" +
                              $"ID: {_studentID}\n" +
                              $"Program: {_studyProgram}\n");
        }

        public double AverageGrade()
        {
            double sum = 0;
            foreach (Grade grade in _grades)
            {
                sum += grade.GradeValue;

            }
            return sum/_grades.Count;
        }

        public double TotalStudyPoints()
        {
            double sum = 0;
            foreach (Subject subject in _subjects)
            {
                sum += subject.StudyPoints;
            }
            return sum;
        }
    }
}
