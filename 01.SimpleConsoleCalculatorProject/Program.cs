using _01.SimpleConsoleCalculatorProject;
using System;
using System.Globalization;

namespace CalculatR
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "";
            do
            {
                Console.Write("Enter your password! ");
                password = Console.ReadLine();
            } while (password != "pass2022");

            Console.Write("Type 1st number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter operation(+,-,/,*,%): ");
            string operation = Console.ReadLine();
            Console.Write("Type 2nd number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            //ternarny operator
            string message = !(firstNumber >= 0 && secondNumber >= 0)
                ? "1st number and 2nd are positive!"
                : "1st number is negativie!";
            Console.WriteLine(message);

            // logical operation
            if (firstNumber >= 0)
                Console.WriteLine("1st number is positive!");
            else
                Console.WriteLine("1st number is negative!");

            if (firstNumber > secondNumber)
                Console.WriteLine("FirstNumber is greater than secondNumber!");
            else if (firstNumber < secondNumber)
                Console.WriteLine("1st number is equal to 2nd number!");
            else
                Console.WriteLine("1st Number is less than secondNumber");


            //switch (operation)
            //{
            //    case "+":
            //        Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}"); break;
            //    case "-":
            //        Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}"); break;
            //    case "*":
            //        Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}"); break;
            //    case "/":
            //        Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}"); break;
            //    case "%":
            //        Console.WriteLine($"{firstNumber} % {secondNumber} = {firstNumber % secondNumber}"); break;
            //    default:
            //        Console.WriteLine("Operation Not Found!");break;
            //}

            string result = operation switch
            {
                "+" => $"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}",
                "-" => $"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}",
                "*" => $"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}",
                "/" => $"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}",
                "%" => $"{firstNumber} % {secondNumber} = {firstNumber % secondNumber}",
                _ => "Operation Not Found!"
            };

            Console.WriteLine(result);

            if (firstNumber > 0)
            {
                int counter = 0;
                while (counter < firstNumber)
                { 
                    Console.WriteLine(counter);  
                    counter+=2;
                }
            }

            for (int i = 0; i < firstNumber; i++)
            {
                Console.WriteLine(i);
            }
            for (int iterator = 1; iterator <= 10; iterator++)
            {
                for (int inneriterator = 1; inneriterator <= 10; inneriterator++)
                {
                    Console.WriteLine($"{iterator} x {inneriterator} = {iterator * inneriterator}");
                }
                Console.WriteLine("\n");
            }
            //// + - / *
            //Console.WriteLine($"Adding {firstNumber + secondNumber}");
            //Console.WriteLine($"Substracting {firstNumber - secondNumber}");
            //Console.WriteLine($"Deviding {firstNumber / secondNumber}");
            //Console.WriteLine($"Multiplying {firstNumber * secondNumber}");

            //// %
            //Console.WriteLine($"Qoldiq {firstNumber % secondNumber}");

            //Calculator calculator = new Calculator();
            //calculator.Calc();
            int[] numbers = { 1, 2, 3, 4, 5 }; 
            int sum = 0; 
            for (int i = 0; i < numbers.Length; i++) 
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                }
                else break;      
            } Console.WriteLine(sum); 
        
        }
    }
}