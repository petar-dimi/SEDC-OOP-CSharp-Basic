using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo 1");

            int numberOfUsers;
            numberOfUsers = 20;

            int numberOfClassrooms = 3;

            Console.WriteLine(numberOfUsers);
            Console.WriteLine(numberOfClassrooms);
            Console.WriteLine($"Number of users: {numberOfUsers}");

            //Data types
            int c = 4;
            short d = 100;
            float averageRate = 4.3f;
            double averageRate2 = 4.3;
            decimal avergeRate3 = 4.3m;
            bool T = true;
            bool notT = false;
            DateTime dateTime = DateTime.Now; 

            Console.WriteLine(averageRate);
            Console.WriteLine(averageRate2);
            Console.WriteLine(avergeRate3);

            string firstName = "Petar";
            string lastName = "Dimishkovski";

            //Declaration
            int a;
            //Initialization
            a = 1;


            //Declaration and Initialization

            int b = 5;

            //Operators
            int x = 5;
            int y = 7;
            int sum = x + y;
            Console.WriteLine(x);
            Console.WriteLine(b);

            Console.WriteLine(sum);

            a = +b; // => a = a + b

            int n1 = 10;
            int n2 = 3;
            int result = n2 / n1; ;
            
            Console.WriteLine($"The result of n2 / n1 is {result}");
            int result2 = n1 / n2; ;
            Console.WriteLine($"The result of n1 / n2 is {result2}");

            float n3 = 10f;
            float n4 = 3f;

            float result4 = n3 / n4;
            Console.WriteLine(result4);
            Console.WriteLine("Exercies:");
            Console.WriteLine();

            // Exercise 01
            Console.WriteLine("Exercise 01");
            double d1 = 10;
            double d2 = 3;
            double dResult = d1 / d2;
            Console.WriteLine(dResult);
            int x1 = 203;
            int x2 = 100;
            double xResult = x1 / (double) x2;
            Console.WriteLine(xResult + "\n");
            

            // Exercise 02
            Console.WriteLine("Exercise 02");
            string userName = "Petar";
            string password = "Password";
            // using concantenation
            string user = userName +" "+ password;  
            Console.WriteLine(user);
            // using interpolation
            Console.WriteLine($"{userName} {password}\n");

            // Exercise 03
            Console.WriteLine("Exercise 03");
            int x3 = 10;
            string human = "man";
            var vResult = x3 + human;
            Console.WriteLine(vResult + "\n");

            // Exercise 04
            Console.WriteLine("Exercise 04");
            int n = 102;
            int m = 5;
            int nmResult = n / m;
            Console.WriteLine(nmResult + "\n");

            //Data Entry

            //Exapmle 01
            Console.WriteLine("Data Entry: \n");
            Console.WriteLine("Input a Number:");
            string input = Console.ReadLine();


            Console.WriteLine("Input a secong number:");
            string input2 = Console.ReadLine();

            int number1;
            bool success = int.TryParse(input, out number1);
            if (!success)
            {
                Console.WriteLine("wrong input for first number");
                return;
            }
            int number2;
            bool success2 = int.TryParse(input2, out number2);
            if (!success2)
            {
                Console.WriteLine("wrong input for second number");
                return;
            }
            int boolResult = number1 + number2;
            Console.WriteLine($"the result is {boolResult}");

            // Example 02

            // Exercise 05
            Console.WriteLine("Exercise 05");
            int branches = 12;
            int basketCapacity = 5;
            int apples = 8;
            Console.WriteLine("Enter number of trees");
            string userTrees = Console.ReadLine();
            int trees;
            bool success3 = int.TryParse(userTrees, out trees);
            if (!success3)
            {
                Console.WriteLine("wrong input for trees");
                return;
            }
            int totalApples = (trees * branches) * apples;
            Console.WriteLine($" the total number of apples is: {totalApples}\n");
            int totalBaskets = totalApples / basketCapacity;
            if ((totalApples % basketCapacity) > 0)
            {
                totalBaskets = totalBaskets + 1;
            }
            Console.WriteLine
                ($"The amount of baskets you will need to carry all {totalApples} apples is : {totalBaskets}");

            // Exercise 06
            Console.WriteLine("Exercise 06");
            Console.WriteLine("Input the first number:");
            string input3 = Console.ReadLine();

            if(!int.TryParse(input3, out int firstNumber))
            {
                Console.WriteLine("Wrong input");
                return; 
            }

            Console.WriteLine("Input the second number:");
            string input4 = Console.ReadLine();

            if (!int.TryParse(input4, out int secondNumber))
            {
                Console.WriteLine("Wrong input");
                return;
            }
            if (firstNumber > secondNumber)
            {
                Console.WriteLine($"First number {firstNumber} is larger than second number {secondNumber}");
            }
            else if (firstNumber < secondNumber)
            {
                Console.WriteLine($"First number {firstNumber} is lower than second number {secondNumber}");
            }
            else 
            {
                Console.WriteLine("Numbers are equal");
            }
            if (firstNumber % 2 == 0)
            {
                Console.WriteLine("First number is even");
            }
            else
            {
                Console.WriteLine("First number is odd");
            }
            if (secondNumber % 2 == 0)
            {
                Console.WriteLine("Second number is even");
            }
            else
            {
                Console.WriteLine("Second number is odd");
            }

            // Exercise 07
                
            Console.WriteLine("Enter a number between 1 and 3");
            string input6 = Console.ReadLine();
            switch (input6)
            {
                case "1": Console.WriteLine("You got a new car");
                break;

                case "2": Console.WriteLine("you got a new plane");
                break;

                case "3": Console.WriteLine("You got a new bike");
                break;

                default: Console.WriteLine("Wrong choise");
                break;   
            }







        }
    }
}