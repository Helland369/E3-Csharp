namespace StudentAdmin
{


    class Grade
    {

        private uint _gradeValue;

        private Student _student;
        private Subject _subject;

        public Grade(uint gradeValue, Subject subject)
        {
            _gradeValue = gradeValue;
            //this.student = student;
            this._subject = subject;
        }
    
        public uint GradeValue { get { return _gradeValue; } set { _gradeValue=value; } }
        public Student Student { get { return _student; } set { _student = value; } }
        public Subject Subject { get { return _subject; } set { _subject = value; } }
    }
}
