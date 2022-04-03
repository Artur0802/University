namespace University
{
    public class Student
    {
        public string FirstName { get; }
        public string LastName { get; }
        public SubjectOrSpecialization Specialization { get; }
        public int Year { get; }

        public Student(string firstname, string lastName, SubjectOrSpecialization specialization, int year)
        {
            FirstName = firstname;
            LastName = lastName;
            Specialization = specialization;
            Year = year;
        }

        public void AddToLecturerCandidates(Lecturer lecturer)
        {
            lecturer.Candidates.Add(this);
        }
    }
}
