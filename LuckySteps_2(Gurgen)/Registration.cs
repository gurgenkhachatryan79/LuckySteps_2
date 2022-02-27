using System;

namespace LuckySteps_2_Gurgen_
{
    class Registration
    {
        public static void UserRegistration(User _User)
        {
            Console.WriteLine("To register for the game, please enter your name and age");
            Console.Write("FullName:");
            string username = Console.ReadLine();
            Console.Write("Age:");
            int age = Convert.ToInt32(Console.ReadLine());
            _User.FullName = username;
            _User.Age = age;
            Console.WriteLine("You have two tables, one has money and the other is empty");
            Console.WriteLine("Start the game you good luck");
        }
    }
}
