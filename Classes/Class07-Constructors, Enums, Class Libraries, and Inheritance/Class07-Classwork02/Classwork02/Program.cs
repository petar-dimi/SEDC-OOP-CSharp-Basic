using Classwork02.Models;

namespace Classwork02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
            Student student1 = new Student("Petko", "Petkovski", "petko@gmail.com", "070123456", "G3");
            Console.WriteLine(student1.GetInfo());
        }
    }
}
