using System.Collections.Generic;

namespace LuckySteps_2_Gurgen_
{
    interface ITicketCreater
    {
        List<int> CreateTicket(int rowTable, int firstRowMany);
    }
}
