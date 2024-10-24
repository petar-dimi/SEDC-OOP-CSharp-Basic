using Homework_10.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10
{
    public class Student : User
    {
        public Subject CurrentSubject { get; set; }
        public List<int> Grades { get; set; }

        public Student(string username, string password, Subject subject)
            : base(username, password, Role.Student)
        {
            CurrentSubject = subject;
            Grades = new List<int>();
        }

       
        public void ViewGrades()
        {
            Console.WriteLine($"Current subject: {CurrentSubject}");
            if (Grades.Count > 0)
            {
                Console.WriteLine("Your grades:");
                foreach (int grade in Grades)
                {
                    Console.WriteLine(grade);
                }
            }
            else
            {
                Console.WriteLine("No grades available.");
            }
        }
    }
}
