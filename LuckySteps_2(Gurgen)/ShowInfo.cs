using System;
using System.Collections.Generic;

namespace LuckySteps_2_Gurgen_
{
    class ShowInfo
    {
        public void PrintTable(List<int> allTables)
        {
            Console.WriteLine();
            for (int i = 0; i < allTables.Count / 2; i++)
            {
                Console.WriteLine(allTables[i] + "        " + allTables[i + allTables.Count / 2]);
            }
            Console.WriteLine();
        }
    }
}
