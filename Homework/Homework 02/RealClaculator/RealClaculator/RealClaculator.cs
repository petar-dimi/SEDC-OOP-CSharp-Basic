namespace RealClaculator
{
    internal class RealClaculator
    {
        static void Main(string[] args)
        {

            //Task 01
            Console.WriteLine("hello");
            Console.WriteLine("\nWelcome to the Real calculator app\n");
            float num1;
            while (true) {
                Console.WriteLine("Plese enter the first number");
                string input = Console.ReadLine();
                if (float.TryParse(input, out num1))
                {
                    break;
                }
                Console.WriteLine("You didn't input a number");
            }
            Console.WriteLine($"The first number you inputed is: {num1}");
            float num2;
            while (true)
            {
                Console.WriteLine("Plese enter the second number");
                string input = Console.ReadLine();
                if (float.TryParse(input, out num2))
                {
                    break;
                }
                Console.WriteLine("You didn't input a number");
            }
            Console.WriteLine($"The second number you inputed is: {num2}\n");

            Console.WriteLine("Now chose which operation you would like to do." +
                "You ca chose from these \"+\",\"-\",\"*\",\"/\" and enter them just by " +
                "typing them their symbol");

            char oprator;
            while (true)
            {
                
                string input = Console.ReadLine();
                if (input == "+" || input == "-" || input == "*" || input == "/")
                {
                    oprator = input[0];
                    break;
                }
                Console.WriteLine("You didn't input one of the provided simbols");
            }
            Console.WriteLine($"The operator you inputed is: {oprator}");
            float result = 0;
            switch (oprator)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine($"The result of {num1} {oprator} {num2} is {result}");
                    break;
                case '-':
                    result = num1 - num2;
                    Console.WriteLine($"The result of {num1} {oprator} {num2} is {result}");
                    break;
                case '*':
                    result = num1 * num2;
                    Console.WriteLine($"The result of {num1} {oprator} {num2} is {result}");
                    break;
                case '/':
                    if (num1 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($"The result of {num1} {oprator} {num2} is {result}");
                    }
                    else
                    {
                        Console.WriteLine("Devision by zero is not allowed.");
                        return;
                    }
                    break;
        
            }

            //Task 02
            Console.WriteLine("\n Enter a number APP\n");
            
            
            int j;
            while (true) 
            {
                Console.WriteLine("Please enter a number from 1 to 10");
                string input2 = Console.ReadLine();
                if(int.TryParse(input2, out j))
                {
                   break;
                }
                Console.WriteLine("You dindnt enter a number");
            }
            Console.WriteLine($"The nunmber you entered is {j}");
            Console.WriteLine($"All the numbers form 1 to {j} are:");
            for (int i = 1; i <= j; i++) {
                Console.WriteLine(i);
            }

            int x;
            while (true)
            {
                Console.WriteLine("Please enter a number from 1 to 10");
                string input3 = Console.ReadLine();
                if (int.TryParse(input3, out x))
                {
                    break;
                }
                Console.WriteLine("You dindnt enter a number");
            }
            Console.WriteLine($"The nunmber you entered is {x}");
            Console.WriteLine($"All the numbers form {x} to 1 are:");
            for (int i = 0;x > i; x--)
            {
                Console.WriteLine(x);
            }

        }
    }
}
