using System;


namespace StrategyPatternLogger
{
    class ConsoleLog : ILogger
    {
        public ConsoleLog()
        {
            Console.Clear();
            this.Log(" Console Logger Created.\n");
        }
        public void Log(string msg)
        {
            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss,") + msg + "\n");
        }
    }
}
