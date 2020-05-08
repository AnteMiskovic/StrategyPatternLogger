

namespace StrategyPatternLogger
{
    interface ILogger
    {
        //definiramo defaultni interface i njegovo ponasanje, dok samu implementaciju prepustamo konkretnim klasama. 
        void Log(string msg);
    }
}
