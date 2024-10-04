using System.Numerics;

namespace Homework06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DogApp");
            Console.WriteLine("Please enter the dogs: name,breed and color");
            
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            string input3 = Console.ReadLine();

            Dog dog1 = new Dog(input1,input2,input3);

            Console.WriteLine("\n" + dog1.Name);
            Console.WriteLine(dog1.Breed);
            Console.WriteLine(dog1.Color);

            Console.WriteLine("Please enter a number form 1 to 3 to chose which action you want your dog to perform" +
                "1: Eating // 2.Playing // 3.ChasingTail");

            string input4 = Console.ReadLine();
            if(int.TryParse(input4 , out int action))
            {
                if (action == 1)
                {
                    Console.WriteLine("you chose the eat option");
                    Console.WriteLine(dog1.Eat());
                   
                }
                else if (action == 2) {
                    Console.WriteLine("you chose the play option");
                    Console.WriteLine(dog1.Play());
                }
                else  if (action == 3)
                {
                    Console.WriteLine("you chose the chasing tail option option");
                    Console.WriteLine(dog1.ChasingTail());
                }
                else
                {
                    Console.WriteLine("Invalid choice: Please enter 1,2 or 3");
                }
            };

            //switch(play2)
            //{
            //    case 0:
            //}


        }
    }
}
