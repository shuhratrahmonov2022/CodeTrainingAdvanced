using System;

namespace SimplePrintConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            String greeting = "Hello, new user!";
            Console.WriteLine(greeting);
            Console.Write("Please type your name: ");
            String userName = Console.ReadLine();
            Console.WriteLine("Hooorey! Now we know your name!");
            Console.WriteLine(userName);
        }
    }
}