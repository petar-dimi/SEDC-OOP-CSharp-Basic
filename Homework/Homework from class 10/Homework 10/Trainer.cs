
using Homework_10.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10
{
    public class Trainer : User
    {
        public Trainer(string username, string password)
            : base(username, password, Role.Trainer) { }

       
        public void ViewAllStudents(List<Student> students)
        {
            Console.WriteLine("All students:");
            foreach (Student student in students)
            {
                Console.WriteLine(student.Username);
            }
        }

        
        public void ViewAllSubjects(List<Student> students)
        {
            Console.WriteLine("All subjects and student count:");
            foreach (Subject subject in Enum.GetValues(typeof(Subject)))
            {
                int count = students.FindAll(s => s.CurrentSubject == subject).Count;
                Console.WriteLine($"{subject} - {count} students");
            }
        }
    }
}
