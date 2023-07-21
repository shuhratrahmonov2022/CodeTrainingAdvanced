using System;

namespace _01.SimpleConsoleCalculatorProject.Classes
{
    public class Calculate
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public string Operation { get; set; }

        public void GetInputs()
        {
            Console.Write("Type 1st number: ");
            FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter operation(+,-,/,*,%): ");
            Operation = Console.ReadLine();
            Console.Write("Type 2nd number: ");
            SecondNumber = Convert.ToInt32(Console.ReadLine());
        }

        public void myMethod()
        {
            FirstNumber %= 10;
            Console.WriteLine(FirstNumber);
        }

        public bool IsFirstNumberPositive() =>
             FirstNumber >= 0;

        public void IsPositive()
        {
            string message = !(IsFirstNumberPositive())
                ? "1st number and 2nd are positive!"
                : "1st number is negativie!";
            Console.WriteLine(message);
        }

        public void CompareInputs()
        {
            if (FirstNumber > SecondNumber)
                Console.WriteLine("FirstNumber is greater than secondNumber!");
            else if (FirstNumber < SecondNumber)
                Console.WriteLine("1st number is equal to 2nd number!");
            else
                Console.WriteLine("1st Number is less than secondNumber");

            // Console.WriteLine($"1st number is grater than 2nd number: {FirstNumber > SecondNumber}");
            // Console.WriteLine($"1st number is grater than or equal 2nd number: {FirstNumber >= SecondNumber}");
            // Console.WriteLine($"1nd number is less than 2st number: {FirstNumber < SecondNumber}");
            // Console.WriteLine($"1nd number is less than or equal 2st number: {FirstNumber <= SecondNumber}");
            // Console.WriteLine($"Numbers are equal: {FirstNumber == SecondNumber}");
            // Console.WriteLine($"Numbers are not equal: {FirstNumber != SecondNumber}");
        }

        public string PrintCalc()
        {
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

            return Operation switch
            {
                "+" => $"{FirstNumber} + {SecondNumber} = {FirstNumber + SecondNumber}",
                "-" => $"{FirstNumber} - {SecondNumber} = {FirstNumber - SecondNumber}",
                "*" => $"{FirstNumber} * {SecondNumber} = {FirstNumber * SecondNumber}",
                "/" => $"{FirstNumber} / {SecondNumber} = {FirstNumber / SecondNumber}",
                "%" => $"{FirstNumber} % {SecondNumber} = {FirstNumber % SecondNumber}",
                _ => "Operation Not Found!"
            };
        }

        public void PrintEvenNumbers()
        {
            if (FirstNumber > 0)
            {
                int counter = 0;
                while (counter < FirstNumber)
                {
                    Console.WriteLine(counter);
                    counter += 2;
                }
            }
        }

        public void PrintMultiplicationTable()
        {
            for (int i = 0; i < FirstNumber; i++)
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
        }

        public void PrintCalcNumber()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                }
                else break;
            }
            Console.WriteLine(sum);
        }
    }
}
