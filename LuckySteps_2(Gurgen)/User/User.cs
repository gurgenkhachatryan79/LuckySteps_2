using System;

namespace LuckySteps_2_Gurgen_
{
    class User : IUser
    {

        public string FullName { get; set; }
        public int Age
        { set; get; }
        public int Amount { get; set; }
        public int WonAmount { get; set; }
        public DateTime PlayingTime { get; set; }
        public int CountPlayedGames { get; set; }

        public User()
        {
            Amount = 0;
            WonAmount = 0;
            PlayingTime = DateTime.Now;
            CountPlayedGames = 0;
        }

    }
}
