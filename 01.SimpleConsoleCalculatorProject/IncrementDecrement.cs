using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SimpleConsoleCalculatorProject
{
    public class IncrementAndDecrement
    {
        public void MyMethod()
        {
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            firstNumber %= 10;
            Console.WriteLine(firstNumber);
        }
    }
}
