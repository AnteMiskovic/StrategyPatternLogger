using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternLogger
{
    interface ILogger
    {
        //definiramo defaultni interface i njegovo ponasanje, dok samu implementaciju prepustamo konkretnim klasama. 
        void Log(string msg);
    }
}
