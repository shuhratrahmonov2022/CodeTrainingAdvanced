using System;

namespace CalculatR
{
    class Program
    {
        static void Main(string[] args) 
        {
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            // + - / *
            Console.WriteLine($"Adding {firstNumber + secondNumber}");
            Console.WriteLine($"Substracting {firstNumber - secondNumber}");
            Console.WriteLine($"Deviding {firstNumber / secondNumber}");
            Console.WriteLine($"Multiplying {firstNumber * secondNumber}");

            // %
            Console.WriteLine($"Qoldiq {firstNumber % secondNumber}");
        }
    }
}