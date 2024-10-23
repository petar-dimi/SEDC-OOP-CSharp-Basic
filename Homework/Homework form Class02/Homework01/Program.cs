namespace Homework01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 01 AverageNumber
            Console.WriteLine("Average Number");
            Console.WriteLine("Enter the first number");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            float num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            float num3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the forth number");
            float num4 = float.Parse(Console.ReadLine());
            float average = (num1 + num2 + num3 + num4 ) / 4 ;
            Console.WriteLine($"The average of {num1} {num2} {num3} {num4} is {average} ");

            // Task 02 SwapNumber
            Console.WriteLine("SwapNumbers");
            Console.WriteLine("Enter the first whole number");
            int num5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second whole number");
            int num6 = int.Parse(Console.ReadLine());
            Console.WriteLine($"The inputed numbers before swapping are: {num5} and {num6}");
            int temp5 = num5;
            num5 = (num5 - num5) + num6;
            num6 = (num6 - num6) + temp5;
            Console.WriteLine($"The inputed numbers after swapping are: {num5} and {num6}");

        }
    }
}