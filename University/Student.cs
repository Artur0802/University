namespace University
{
    public class Student
    {
        private SubjectOrSpecialization _specialization;
        private string _firstName;
        private string _lastName;
        private int _year;

        public string FirstName
        {
            get
            {
                return _firstName;
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
        }
        public SubjectOrSpecialization Specialization
        {
            get
            {
                return _specialization;
            }
        }
        public int Year { get; set; }

        public Student(string firstname, string lastName, SubjectOrSpecialization specialization, int year)
        {
            _firstName = firstname;
            _lastName = lastName;
            _specialization = specialization;
            _year = year;
        }

        public void AddToLecturerCandidates(Lecturer lecturer)
        {
            lecturer.Candidates.Add(this);
        }
    }
}
