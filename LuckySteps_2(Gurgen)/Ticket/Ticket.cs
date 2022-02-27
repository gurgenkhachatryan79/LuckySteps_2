using System.Collections.Generic;

namespace LuckySteps_2_Gurgen_
{
    class Ticket : ITicket
    {
        public List<int> LeftTable { get; set; }
        public List<int> RightTable { get; set; }
        public List<int> AllTables { get; set; }
        public int RowTable { get; set; }
        public int FirstRowMany { get; set; }


        public Ticket(int rowTable, int firstRowMany)
        {
            RowTable = rowTable;
            FirstRowMany = firstRowMany;
            LeftTable = new List<int>();
            RightTable = new List<int>();
            AllTables = new List<int>();
        }

        public void Create(ITicketCreater creater)
        {
            AllTables = creater.CreateTicket(RowTable, FirstRowMany);
            for (int i = 0; i < RowTable; i++)
            {
                LeftTable.Add(AllTables[i]);
                RightTable.Add(AllTables[i + RowTable]);
            }
        }
    }
}
