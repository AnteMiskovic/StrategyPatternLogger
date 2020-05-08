using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
