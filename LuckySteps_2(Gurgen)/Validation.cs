using System;

namespace LuckySteps_2_Gurgen_
{
    class Validation
    {
        public static void ChooseValidation(char chosse)
        {
            while (chosse != 'L' && chosse != 'R' && chosse != 'S')
            {
                Console.WriteLine("Invalid chosse");
                Console.WriteLine("Please chosse L (left table)");
                Console.WriteLine("Please chosse R (right table)");
                Console.WriteLine("Please chosse S (stop game)");
                chosse = Convert.ToChar(Console.ReadLine());
            }
        }
    }
}
