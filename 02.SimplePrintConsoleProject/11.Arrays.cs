using System;

namespace _02.SimplePrintConsoleProject
{
    public class ArrayClass
    {
        public void TellAboutFriends(string userName, int userAge)
        {
            string[] friendsName = new string[3];
            friendsName[0] = "Kasee";
            friendsName[1] = "Vasya";
            friendsName[2] = userName;
            int[] friendsAge = { 1, 2, userAge };

            // 1
            //Console.WriteLine($"{friendsName[0]} is {friendsAge[0]} year old!");
            //Console.WriteLine($"{friendsName[1]} is {friendsAge[1]} year old!");
            //Console.WriteLine($"{friendsName[2]} is {friendsAge[2]} year old!");
            
            // 2
            //foreach (string item in friendsName)
            //{
            //    Console.WriteLine(item);
            //}

            // 3
            for (int itaration = 0; itaration < friendsName.Length; itaration++)
            {
                Console.WriteLine($"{friendsName[itaration]} is {friendsAge[itaration]}");
            }
        }
    }
}
