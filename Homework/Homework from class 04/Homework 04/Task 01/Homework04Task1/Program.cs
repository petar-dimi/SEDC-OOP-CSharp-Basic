namespace Homework_04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[6];


            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter number:.{i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }


            int sumOfEvens = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    sumOfEvens += number;
                }
            }


            Console.WriteLine($"The result is: {sumOfEvens}");
        }
    }
}

