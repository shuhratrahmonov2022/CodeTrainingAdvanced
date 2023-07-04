using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SimpleConsoleCalculatorProject
{
    public class Calculator
    {
        public void Calc()
        {
            Console.Write("Type 1st number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Type 2nd number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"1st number is grater than 2nd number: {firstNumber > secondNumber}");
            Console.WriteLine($"1st number is grater than or equal 2nd number: {firstNumber >= secondNumber}");
            Console.WriteLine($"1nd number is less than 2st number: {firstNumber < secondNumber}");
            Console.WriteLine($"1nd number is less than or equal 2st number: {firstNumber <= secondNumber}");
            Console.WriteLine($"Numbers are equal: {firstNumber == secondNumber}");
            Console.WriteLine($"Numbers are not equal: {firstNumber != secondNumber}");
        }
    }
}
