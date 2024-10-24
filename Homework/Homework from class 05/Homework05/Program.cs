using System.Threading.Channels;

namespace Homework05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Age Calculator
            Console.WriteLine("AgeCallulator\n");
            Console.WriteLine("Please enter your Bithdaydate");
            string input = Console.ReadLine();
            if (DateTime.TryParse(input, out DateTime bithdayDate))
            {
                int age = AgeCalculator(bithdayDate);
                Console.WriteLine($"Your age is: {age}");

            }
            else 
            {
                Console.WriteLine("Invalid format.Please use yyy-mm-dd");
            }

            //Substrings
            Console.WriteLine("\nSubstrings\n");
            Console.WriteLine("Enter a number N between 1 and 29");
            string input2 = Console.ReadLine();
            if (int.TryParse(input2, out int length))
            {
                string result = Substrings(length);
                Console.WriteLine(result);

            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            
        }
        public static string Substrings(int n)
        {
            string baseString = "Hello from SEDC Codecademy 2024";

            if (n < 0)
            {
                Console.WriteLine("Please enter a positive number between 1 and 29");
            }
            else if (n > baseString.Length) 
            {
                return $"The number exceeds the string length of {baseString.Length}";
                
            }
            string substring = baseString.Substring(0, n);
            int substringLength = substring.Length;
            return $"Substring: \"{substring}\"\nLength: {substringLength}";
        }

        public static int AgeCalculator(DateTime birthdayDate)
        {
            int yearsOld = DateTime.Now.Year - birthdayDate.Year;
            if (DateTime.Now < birthdayDate.AddYears(yearsOld))
            {
                yearsOld--;
            }
            return yearsOld;
        }

    }
}
