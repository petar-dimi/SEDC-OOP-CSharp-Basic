namespace Homeework04Task04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<string> names = new List<string>();

            string userInput;
            do
            {
                
                Console.Write("Enter a name: ");
                string name = Console.ReadLine();
                names.Add(name); 

                
                Console.Write("Do you want to enter another name? (Y/N): ");
                userInput = Console.ReadLine().ToUpper(); 
            }
            while (userInput == "Y"); 

            
            Console.WriteLine("\nThe names you entered are:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
