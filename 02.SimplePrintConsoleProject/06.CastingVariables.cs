using System;

namespace _02.SimplePrintConsoleProject
{
    public class CastingVariables
    {
        public void MyCasting()
        {
            //   1
            // implicit casting  
            // short => int => long => float => double => decimal
            float pi = 3.14f;
            double bigPi = pi;
            short age = 22;
            decimal deciAge = age; // 22.0000                      

            //   2
            Console.WriteLine(deciAge.ToString());

            //   3
            // explicit casting
            int floraTypes = 3232;
            short smallFloraType = (short)floraTypes;
            int piInteger = (int)bigPi;
            Console.WriteLine(piInteger);

            //   4
            // Convertion
            Convert.ToInt32("23");
            decimal randomNumber = Convert.ToDecimal("23");
            // int => Int32
            // short => Int16;
            // long => Int64

            // 1. Implicit casting
            // 2. deciAge.ToString() 
            // 3. Explicit casting
            // 4. Convert.To...
        }
        public void DataReadConsole()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            string greeting = $"Hello, {name}";
            Console.WriteLine(greeting);
            Console.Write("Enter your age: ");
            string ageAsString = Console.ReadLine();
            int age = Convert.ToInt32(ageAsString);
            Console.WriteLine($"Successfully converted! {age}");
        }
    }
}
