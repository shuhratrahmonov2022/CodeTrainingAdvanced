using System;
using _01.SimpleConsoleCalculatorProject.Classes;

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
            calculate.myMethod();
            calculate.IsPositive();
            calculate.CompareInputs();
            calculate.PrintCalc();

            string result = calculate.PrintCalc();
            Console.WriteLine(result);

            calculate.PrintEvenNumbers();
            calculate.PrintMultiplicationTable();
            calculate.PrintCalcNumber();
        }
    }
}