using System;

namespace _01.SimpleConsoleCalculatorProject.Classes
{
    public class Security
    {
        public void CheckPassword()
        {
            string password = "";
            do
            {
                Console.Write("Enter your password! ");
                password = Console.ReadLine();
            } while (password != "pass2022");
        }
    }
}
