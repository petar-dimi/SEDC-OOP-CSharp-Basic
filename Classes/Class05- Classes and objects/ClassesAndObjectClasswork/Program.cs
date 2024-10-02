namespace ClassesAndObjectClasswork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Messages.Hello();
            Messages.Waiting();
            Messages.Bye();
        }
    }

    class Human
    {
        string name;
        int age;

        void Eat()
        {
            Console.WriteLine(name + "is eating");
        }
        void Sleep()
        {
            Console.WriteLine(name + "is eating");
        }




    }
}
