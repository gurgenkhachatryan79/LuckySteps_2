namespace LuckySteps_2_Gurgen_
{
    interface IGames
    {
        User _User { get; set; }
        Ticket _Ticket { set; get; }
        int Step { set; get; }
        void StartGame();
    }
}
