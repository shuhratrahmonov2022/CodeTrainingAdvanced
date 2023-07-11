using _01.SimpleConsoleCalculatorProject;
using _01.SimpleConsoleCalculatorProject.Classes;
using System;
using System.Globalization;

namespace CalculatR
{
    class Program
    {
        static void Main(string[] args)
        {
            Security security = new Security();
            security.CheckPassword();

            Calculate calculate = new Calculate();
            calculate.GetInputs();
           
            string message = !(calculate.IsFirstNumberPositive())
                ? "1st number and 2nd are positive!"
                : "1st number is negativie!";
            Console.WriteLine(message);

            calculate.CompareInputs();
            calculate.PrintCalc();

            string result = calculate.PrintCalc();
            Console.WriteLine(result);

           calculate.PrintEvenNumbers();
            calculate.PrintMultiplicationTable();
           
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