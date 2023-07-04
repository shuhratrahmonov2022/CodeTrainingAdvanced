using System;

namespace _02.SimplePrintConsoleProject
{
    public class DecimalAndDoubleDataType
    {
        public void DecimalAndDouble()
        {
            double width = 1.1;
            double height = 0.3;
            double sum = 1.4;
            Console.WriteLine($"Double = {sum == height + width}");

            decimal width1 = 1.1m;
            decimal height1 = 0.3m;
            decimal sum1 = 1.4m;
            Console.WriteLine($"Decimal = {sum1 == height1 + width1}");
        }
    }
}
