namespace Homework09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Queue<int> numbers = new Queue<int>();
            string userChoice;

            do
            {
                Console.Write("Enter a number: ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                   
                    numbers.Enqueue(number);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }

                
                Console.Write("Do you want to input another number? (Y/N): ");
                userChoice = Console.ReadLine().ToUpper();

            } while (userChoice == "Y");

            
            Console.WriteLine("\nYou entered the following numbers:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("End of program.");
        }
    }
}
