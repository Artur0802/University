using System;
using System.Collections.Generic;
using System.Linq;

namespace University
{
    public class Lecturer
    {
        private int _minCandidatesCount = 5;
        private SubjectOrSpecialization _subject;
        private string _firstName;
        private string _lastName;
        
        private List<Student> _group { get; set; }
        public List<Student> Candidates { get; set; }

        public Lecturer(string firstname, string lastName, SubjectOrSpecialization subject)
        {
            _firstName = firstname;
            _lastName = lastName;
            _subject = subject;
            Candidates = new List<Student>();
        }

        public void MakeGroup()
        {
            if (Candidates.Count >= _minCandidatesCount)
            {
                if (Candidates.Any(s => s.Specialization == _subject))
                {
                    _group = Candidates.Where(s => s.Specialization == _subject).ToList();
                    Console.WriteLine("{0} group has been made up for {1} {2}." + Environment.NewLine + "Students in the group:" + Environment.NewLine, _subject, _firstName, _lastName);
                    foreach (var student in _group)
                    {
                        Console.WriteLine("{0} {1}, year: {2}.", student.FirstName, student.LastName, student.Year);
                    }
                }
                else
                {
                    Console.WriteLine("Impossible to make {0} group for lector {1} {2}.", _subject, _firstName, _lastName);
                    Console.WriteLine("There is not any student which specialization meets lecturers subject." + Environment.NewLine);
                }
            }
            else
            {
                Console.WriteLine("Impossible to make {0} group for lector {1} {2}", _subject, _firstName, _lastName);
                Console.WriteLine("Amount of candidates is not enough." + Environment.NewLine);                
            }
        }
    }
}
