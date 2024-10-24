using Homework_10.Enums;

namespace Homework_10
{
    internal class Program
    {
        static List<User> users = new List<User>();
        static List<Student> students = new List<Student>();

        static void Main(string[] args)
        {
            
            Admin admin = new Admin("Sara", "sara123");
            users.Add(admin);
            Trainer trainer = new Trainer("Slave", "Ivanovski123");
            users.Add(trainer);
            Student student = new Student("Petar", "dimi123", Subject.Math);
            student.Grades.Add(95);
            student.Grades.Add(80);
            users.Add(student);
            students.Add(student);

            Console.WriteLine("Welcome to Academy Management App");
            while (true)
            {
                Console.Write("Enter username: ");
                string username = Console.ReadLine();
                Console.Write("Enter password: ");
                string password = Console.ReadLine();

                User loggedInUser = users.Find(u => u.Username == username && u.Password == password);
                if (loggedInUser == null)
                {
                    Console.WriteLine("Invalid login credentials.");
                    continue;
                }

                if (loggedInUser is Admin adminUser)
                {
                    HandleAdminActions(adminUser);
                }
                else if (loggedInUser is Trainer trainerUser)
                {
                    HandleTrainerActions(trainerUser);
                }
                else if (loggedInUser is Student studentUser)
                {
                    HandleStudentActions(studentUser);
                }
            }
        }

        static void HandleAdminActions(Admin admin)
        {
            Console.WriteLine("Admin logged in.");
            while (true)
            {
                Console.WriteLine("1. Add User");
                Console.WriteLine("2. Remove User");
                Console.WriteLine("3. Logout");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Write("Enter username: ");
                    string username = Console.ReadLine();
                    Console.Write("Enter password: ");
                    string password = Console.ReadLine();
                    Console.WriteLine("Enter role (Admin, Trainer, Student): ");
                    string roleInput = Console.ReadLine();

                    if (Enum.TryParse(roleInput, out Role role))
                    {
                        if (role == Role.Student)
                        {
                            Console.WriteLine("Enter subject (Math, Physics, History, Programming): ");
                            string subjectInput = Console.ReadLine();
                            if (Enum.TryParse(subjectInput, out Subject subject))
                            {
                                Student newStudent = new Student(username, password, subject);
                                admin.AddUser(users, newStudent);
                                students.Add(newStudent);
                            }
                        }
                        else
                        {
                            User newUser = new User(username, password, role);
                            admin.AddUser(users, newUser);
                        }
                    }
                }
                else if (choice == "2")
                {
                    Console.Write("Enter username to remove: ");
                    string username = Console.ReadLine();
                    admin.RemoveUser(users, username);
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Logging out...");
                    break;
                }
            }
        }

        static void HandleTrainerActions(Trainer trainer)
        {
            Console.WriteLine("Trainer logged in.");
            while (true)
            {
                Console.WriteLine("1. View All Students");
                Console.WriteLine("2. View All Subjects");
                Console.WriteLine("3. Logout");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    trainer.ViewAllStudents(students);
                }
                else if (choice == "2")
                {
                    trainer.ViewAllSubjects(students);
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Logging out...");
                    break;
                }
            }
        }

        static void HandleStudentActions(Student student)
        {
            Console.WriteLine($"Welcome {student.Username}");
            student.ViewGrades();
        }
    }
}
