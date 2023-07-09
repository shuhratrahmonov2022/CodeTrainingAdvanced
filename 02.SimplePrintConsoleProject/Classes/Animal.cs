using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SimplePrintConsoleProject.Classes
{
    public class Animal
    {
        // field
        private int age;
        // Property
        public string Name { get; set; }
        public int Age { get; set; }
        public int AgeDifference { get; set; }

        public Animal()
        {
            Name = "No name";
            Age = 0;
            AgeDifference = 0;
        }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public Animal(string name, int animalAge, int userAge)
        {
            Name = name;
            Age = animalAge;
            CalculateAgeDifferenceWithNoReturn(userAge, animalAge);
        }

        public void PrintAgeDifference()
        {
            Console.WriteLine($"The difference between your and {Name}`s age is {AgeDifference}");
        }

        public void CompareAges(int userAge)
        {
            if (userAge > Age)
            {
                Console.WriteLine("You are older!");
            }
            else if (userAge == Age)
            {
                Console.WriteLine("You are equal!");
            }
            else
            {
                Console.WriteLine("Your friend is older!");
            }
        }

        public void CalculateAgeDifferenceWithNoReturn(int userAge)
        {
            AgeDifference = userAge - Age;
        }

        public int CalculateAgeDifference(int userAge, int animalAge)
        {
            return userAge - animalAge;
        }

        public void Greet(string userName)
        {
            if (userName == "")
            {
                userName = "Unknown Person";
            }
            Console.WriteLine($"Hello, {userName}");
        }

        private void CalculateAgeDifferenceWithNoReturn(int userAge, int animalAge)
        {
            AgeDifference = userAge - animalAge;
        }
    }
}
