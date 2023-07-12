using System;
using _02.SimplePrintConsoleProject.Classes;

namespace _02.SimplePrintConsoleProject
{
    public class ifStatements
    {
        public void MyIfMethods()
        {
            Animal animal = new Animal(name: "kescha", age: 3);

            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();
            animal.Greet(userName);

            Console.Write("Enter your age: ");
            string ageAsString = Console.ReadLine();
            Console.WriteLine("Converting... ");
            int userAge = Convert.ToInt32(ageAsString);
            Console.WriteLine($"Successfully converted! {userAge}");

            animal.CalculateAgeDifferenceWithNoReturn(userAge);
            animal.PrintAgeDifference();
            animal.CompareAges(userAge);

            ArrayClass array = new ArrayClass();
            array.TellAboutFriends(userName, userAge); 
        }
    }
} 
