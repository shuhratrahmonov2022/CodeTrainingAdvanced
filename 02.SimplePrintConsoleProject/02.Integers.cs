using System;

namespace _02.SimplePrintConsoleProject
{
    public class Integers
    {
        public void MyIntegersNumber()
        {
             string name = Console.ReadLine();
             short age = 22;

            //interpolated string
            string greeting = $"Hello! {name}";
            Console.WriteLine($"Your age is  probably {age}");
     
            // short,   int,   long
            //syntax
            short studentCount = 30;
            int populationCount = 40_000;
            long worldPopulation = 7_000_000_000;

            // size
            Console.WriteLine($"The size of short data type: {sizeof(short)}");
            Console.WriteLine($"The size of int data type: {sizeof(int)}");
            Console.WriteLine($"The size of long data type: {sizeof(long)}");

            // range
            Console.WriteLine(short.MinValue);
            Console.WriteLine(short.MaxValue);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);

            //unsigned
            Console.WriteLine(ushort.MinValue);
            Console.WriteLine(ushort.MaxValue);
            Console.WriteLine(uint.MinValue);
            Console.WriteLine(uint.MaxValue);
            Console.WriteLine(ulong.MinValue);
            Console.WriteLine(ulong.MaxValue);
        }
    }
}
