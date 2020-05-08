using System;
using System.IO;

namespace StrategyPatternLogger
{
    class FileLog : ILogger
    {

        private string FilePath { get; set; }
        public FileLog()
        {
           
            this.FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logger.txt");
            Console.WriteLine("File Loger initialized .txt file at \n" + FilePath + "\n");
            this.Log("File Logger Created.\n");
        }

        public void Log(string msg)
        {          
            File.AppendAllText(FilePath, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss,") + msg + "\n");           
        }

    }
}
