using System;

namespace _02.SimplePrintConsoleProject
{
    public class ArrayClass
    {
        public void MyArrayMethod()
        {
            MyClass myClass = new MyClass();

            string[] friendsName = new string[3];
            friendsName[0] = "Kasee";
            friendsName[1] = "Vasya";
            friendsName[2] = myClass.Names();
            int[] friendsAge = { 1, 2, myClass.Ages() };

            Console.WriteLine($"{friendsName[0]} is {friendsAge[0]} year old!");
            Console.WriteLine($"{friendsName[1]} is {friendsAge[1]} year old!");
            Console.WriteLine($"{friendsName[2]} is {friendsAge[2]} year old!");

            foreach (string item in friendsName)
            {
                Console.WriteLine(item);
            }
            for (int itaration = 0; itaration < friendsName.Length; itaration++)
            {
                Console.WriteLine($"{friendsName[itaration]} is {friendsAge[itaration]}");
            }
        }
    }
}
