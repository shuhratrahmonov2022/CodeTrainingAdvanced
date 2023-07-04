using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SimplePrintConsoleProject
{
    public class FirstFeature
    {
        public void Feature(int age)
        {
            int Age = 3;
            int ageDeference = age - Age;
            Console.WriteLine($"Age Deference: {ageDeference}");
        }
    }
}
