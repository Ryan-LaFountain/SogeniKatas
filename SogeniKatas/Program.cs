using System;

namespace SogeniKatas
{
    class Program
    {
        static void Main(string[] args)
        {
            bool active = true;
            Console.WriteLine("Welcome to FizzBuzz!");
            while (active)
            {
                Console.WriteLine("Enter a number.");
                string input = Console.ReadLine();
                int number;
                if (input == "Exit")
                {
                    active = false;
                    Console.WriteLine("Exiting...");
                    Console.WriteLine("Thank you for playing Fizz Buzz!");
                    Console.ReadLine();
                    continue;
                }

                if(!Int32.TryParse(input, out number))
                {
                    Console.WriteLine($"Error: Unable to Convert {input} to a number.");
                    Console.WriteLine("Enter a number.");
                    Console.ReadLine();
                }

                string output = FizzBuzz.EvaluateNumber(number);

                Console.WriteLine(output);
            }
            
        }
    }
}
