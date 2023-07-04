using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SimplePrintConsoleProject
{
    public class CharType
    {
        public void MyChar()
        {
            Console.WriteLine("SizeOf: " + sizeof(char) + " bytes");
            char smallA = 'a';
            char capitalA = 'A';

            Console.WriteLine((int)smallA);
            Console.WriteLine((int)capitalA);
        }
    }
}
