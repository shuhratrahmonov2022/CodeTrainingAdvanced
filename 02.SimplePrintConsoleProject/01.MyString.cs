using System;

namespace _02.SimplePrintConsoleProject
{
    public class MyString
    {
        public void StringMethod()
        {
            // variable = type -> VariableName -> Value
            string greeting = "Hello, new User";
            Console.WriteLine(greeting);
            Console.Write("Please, type your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Hoorey! We know your name! " + userName);
        }
    }
}
