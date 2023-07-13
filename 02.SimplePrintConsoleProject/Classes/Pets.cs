using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SimplePrintConsoleProject.Classes
{
    public class Pets : Animal
    {
        public Pets(string name, int age)
            :base(name,  age)
        {
            
        }

        public override void Greet2(string userName)
        {
            Console.WriteLine("hello");
        }
    }
}
