using System;
using System.IO;

namespace LuckySteps_2_Gurgen_.Log
{
    class Writer
    {
        public void WriteText(string text)
        {
            string pathFolder = "..//..//..//Log/Masage//";
            string pathfile = pathFolder + "file.txt";
            DirectoryInfo directoryInfo = new DirectoryInfo(pathFolder);
            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(pathfile, true))
                {
                    streamWriter.WriteLine(text);
                };
            }
            catch (FileNotFoundException fnf) { Console.WriteLine(fnf.Message); }
            catch (DirectoryNotFoundException dnf) { Console.WriteLine(dnf.Message); }

        }
    }
}
