using System;

namespace _02.SimplePrintConsoleProject.Classes
{
    public class Bird : Animal
    {
        public Bird(string name, int age)
            : base(name, age)
        {

        }

        public override void Greet2(string userName)
        {
            Console.WriteLine();
        }
    }
}
