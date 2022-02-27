using System.Collections.Generic;

namespace LuckySteps_2_Gurgen_
{
    interface ITicket
    {
        List<int> LeftTable { set; get; }
        List<int> RightTable { set; get; }
        List<int> AllTables { set; get; }
        int RowTable { get; set; }
        int FirstRowMany { get; set; }
    }
}
