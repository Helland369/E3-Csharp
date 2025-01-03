namespace StudentAdmin
{


    class Subject
    {

        private int _studyPoints;
        private string _subjectCode, _subjectName;

        public Subject(string subjectCode, string subjectName, int studyPoints)
        {
            _subjectCode = subjectCode;
            _subjectName = subjectName;
            _studyPoints = studyPoints;
        }

        public int StudyPoints { get { return _studyPoints; } set { _studyPoints=value; } }
        public string SubjectCode { get { return _subjectCode; } set { _subjectCode=value; } }
        public string SubjectName { get { return _subjectName; } set { _subjectName=value; } }
    }
}
