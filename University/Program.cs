using System;

namespace University
{
    class Program
    {
        static void Main(string[] args)
        {
            Lecturer lecturer1 = new Lecturer("Antony", "Adams", SubjectOrSpecialization.Biology);
            Lecturer lecturer2 = new Lecturer("Conor", "Cristensen", SubjectOrSpecialization.Philology);
            Lecturer lecturer3 = new Lecturer("Bob", "Bauer", SubjectOrSpecialization.Math);

            Student student1 = new Student("Andrew", "Ashley", SubjectOrSpecialization.Biology, 1);

            Student student2 = new Student("Barny", "Barns", SubjectOrSpecialization.Math, 2);
            Student student3 = new Student("Cris", "Collins", SubjectOrSpecialization.Biology, 1);
            Student student4 = new Student("Derek", "Dredd", SubjectOrSpecialization.Math, 3);
            Student student5 = new Student("Ethan", "Escobar", SubjectOrSpecialization.Math, 1);
            Student student6 = new Student("Frank", "Falcon", SubjectOrSpecialization.Biology, 5);

            Student student7 = new Student("Grant", "Garisson", SubjectOrSpecialization.Philology, 4);
            Student student8 = new Student("Harry", "Harrison", SubjectOrSpecialization.Biology, 4);
            Student student9 = new Student("Isaac", "Iverson", SubjectOrSpecialization.Math, 4);
            Student student10 = new Student("Jack", "Jackson", SubjectOrSpecialization.Biology, 2);
            Student student11 = new Student("Kevin", "Kleberson", SubjectOrSpecialization.Math, 5);

            student1.AddToLecturerCandidates(lecturer1);

            student2.AddToLecturerCandidates(lecturer2);
            student3.AddToLecturerCandidates(lecturer2);
            student4.AddToLecturerCandidates(lecturer2);
            student5.AddToLecturerCandidates(lecturer2);
            student6.AddToLecturerCandidates(lecturer2);

            student7.AddToLecturerCandidates(lecturer3);
            student8.AddToLecturerCandidates(lecturer3);
            student9.AddToLecturerCandidates(lecturer3);
            student10.AddToLecturerCandidates(lecturer3);
            student11.AddToLecturerCandidates(lecturer3);

            lecturer1.MakeGroup();
            lecturer2.MakeGroup();
            lecturer3.MakeGroup();
            Console.ReadLine();
        }
    }
}
