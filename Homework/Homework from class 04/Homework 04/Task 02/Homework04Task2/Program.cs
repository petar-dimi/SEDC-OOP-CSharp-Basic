namespace Homework04Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] studentsG1 = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            string[] studentsG2 = { "Mile", "Gile", "Bojan", "Ivan", "Stefan" };

           
            Console.WriteLine("Enter student group: (there are 1 and 2)");
            int groupNumber = int.Parse(Console.ReadLine());

            
            if (groupNumber == 1)
            {
                Console.WriteLine("The Students in G1 are:");
                foreach (string student in studentsG1)
                {
                    Console.WriteLine(student);
                }
            }
            else if (groupNumber == 2)
            {
                Console.WriteLine("The Students in G2 are:");
                foreach (string student in studentsG2)
                {
                    Console.WriteLine(student);
                }
            }
            else
            {
                Console.WriteLine("Invalid group number. Please enter 1 or 2.");
            }
        }
    }
}
