namespace Homework07Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userChoice;

            do
            {
                
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();
                if (decimal.TryParse(input, out decimal number))
                {
                    
                    NumberStats(number);
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a valid number.");
                }

                
                Console.Write("Press Y to try again or X to exit: ");
                userChoice = Console.ReadLine().ToUpper();
            }
            while (userChoice == "Y");

            Console.WriteLine("Goodbye!");
        }

        
        static void NumberStats(decimal number)
        {
            Console.WriteLine($"\nStats for number: {number}");

            
            if (number > 0)
            {
                Console.WriteLine("Positive");
            }
            else if (number < 0)
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("Zero");  
            }

           
            if (number == Math.Floor(number))
            {
                Console.WriteLine("Integer");
            }
            else
            {
                Console.WriteLine("Decimal");
            }

            
            if (number == Math.Floor(number))
            {
                if ((int)number % 2 == 0)
                {
                    Console.WriteLine("Even");
                }
                else
                {
                    Console.WriteLine("Odd");
                }
            }

            Console.WriteLine(); 
        }
    }
}
