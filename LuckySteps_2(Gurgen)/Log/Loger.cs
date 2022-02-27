using System;

namespace LuckySteps_2_Gurgen_.Log
{
    class Loger : ILoger
    {
        string senttext;

        public void LogError(string text)
        {
            senttext = Log.Error + " " + DateTime.Now + " " + text;
            new Writer().WriteText(senttext);
        }

        public void LogInformation(string text)
        {
            senttext = Log.Information + " " + DateTime.Now + " " + text;
            new Writer().WriteText(senttext);
        }

    }
}
