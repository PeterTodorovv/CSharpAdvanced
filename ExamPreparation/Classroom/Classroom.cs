using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomProject
{
    public class Classroom
    {
        
        public Classroom(int capacity)
        {
            Capacity = capacity;
            students = new List<Student>();
        }
        public int Capacity { get; set; }
        private List<Student> students;

        private int Count { get { return students.Count; } }

        public string RegisterStudent(Student student)
        {
            if(Capacity >= Count + 1)
            {
                students.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }

            return "No seats in the classroom";
        }

        public string DismissStudent(string firstName, string lastName)
        {
            if(students.Any(s => s.FirstName == firstName && s.LastName == lastName))
            {
                students.Remove(students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName));
                return $"Dismissed student {firstName} {lastName}";
            }

            return "Student not found";
        }

        public string GetSubjectInfo(string subject)
        {
            if(!students.Any(s => s.Subject == subject))
            {
                return "No students enrolled for the subject";
            }

            StringBuilder txt = new StringBuilder();
            txt.AppendLine($"Subject: {subject}\nStudents:");

            foreach(var student in students.Where(s => s.Subject == subject))
            {
                txt.AppendLine($"{student.FirstName} {student.LastName}");
            }

            return txt.ToString().Trim();
        }

        public int GetStudentsCount()
        {
            return Count;
        }

        public Student GetStudent(string firstName, string lastName)
        {
            return students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);
        }
    }
}
