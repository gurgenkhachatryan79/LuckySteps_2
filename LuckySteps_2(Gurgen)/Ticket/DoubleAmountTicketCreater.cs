using System;
using System.Collections.Generic;

namespace LuckySteps_2_Gurgen_
{
    class DoubleAmountTicketCreater : ITicketCreater
    {
        public List<int> CreateTicket(int rowTable, int firstRowMany)
        {
            List<int> leftTable = new List<int>();
            List<int> rightTable = new List<int>();
            Random random = new Random();
            for (int i = 0; i < rowTable; i++)
            {
                int randomnumber = random.Next();
                if (randomnumber % 2 == 0)
                { leftTable.Add(firstRowMany); rightTable.Add(0); }
                else { leftTable.Add(0); rightTable.Add(firstRowMany); }
                firstRowMany *= 2;
            }
            leftTable.AddRange(rightTable);
            return leftTable;
        }
    }
}
