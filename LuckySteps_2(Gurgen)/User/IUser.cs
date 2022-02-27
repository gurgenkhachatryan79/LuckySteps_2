using System;

namespace LuckySteps_2_Gurgen_
{
    interface IUser
    {
        string FullName { set; get; }
        int Age { set; get; }
        int Amount { set; get; }
        int WonAmount { set; get; }
        DateTime PlayingTime { set; get; }
        int CountPlayedGames { set; get; }

    }
}
