namespace ClassesAndObjectClasswork
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Human trainer = new Human();
            trainer.FirstName = "Risto";
            trainer.LastName = "Panchevski";
            trainer.DateOfBirth = new DateTime(1989,7,20);
            string reslut = trainer.GetPersonStats();
            Console.WriteLine(reslut);  

            Human trainer2 = new Human();
            trainer2.FirstName = "Slave";
            trainer2.LastName = "Ivanovski";
            trainer2.DateOfBirth = DateTime.Now.AddYears(-20);
            string result2 = trainer2.GetPersonStats();
            Console.WriteLine(result2);

            Human trainer3 = new Human("Pisto","Panchevski",new DateTime(1989, 7, 20));
            Console.WriteLine(trainer3.GetPersonStats());

        }
        public static string GetStringInputFromConsole(string displayMessage)
        {
            Console.WriteLine(displayMessage);
            string input = Console.ReadLine();

            return input;

        }
        
    }

}