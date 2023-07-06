using System;

namespace _02.SimplePrintConsoleProject
{
    public class ifStatements
    {
        public void MyIfMethods()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            string greeting = $"Hello, {name}";
            Console.WriteLine(greeting);
            Console.Write("Enter your age:");
            string ageAsString = Console.ReadLine();
            Console.WriteLine("Converting...");
            int age = Convert.ToInt32(ageAsString);
            Console.WriteLine($"Successfully converted! {age}");
            
            int FriendAge = 13;
            int ageDifference = age - FriendAge;
            Console.WriteLine($"The difference between your Age`s age is {ageDifference}");

            if (age > FriendAge)
            {
                Console.WriteLine("You are older!");
            }
            else 
            {
                Console.WriteLine("Your friend is older!");
            }
        }
    }
}
