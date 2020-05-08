
namespace StrategyPatternLogger
{
     internal class Calculator 
    {
        private ILogger _logger; //private logger with defined behavior (after constructor).

        public Calculator(ILogger logger) //Constructor for initializing private _logger. We are passing concrete type (which is of ILogger) specified by user.
        {
            this._logger = logger;
        }

        public void Log(string msg) //Calculator method which will delegate function of "logging" to concrete logging behavior defined in private _logger.
        {
            this._logger.Log(msg);
        }


        // Add two doubles and returns the sum  
        public double Add(double num1, double num2)
        {
            this.Log(" Entered Function Add: " + "with operands -> " + num1.ToString() + " " + num2.ToString());
            return num1 + num2;
        }

        // Multiply two doubles,logs operation and returns the result  
        public double Multiply(double num1, double num2)
        {
            this.Log(" Entered Function Multiply: " + "with operands -> " + num1.ToString() + " " + num2.ToString());
            return num1 * num2;

        }
        // Subtracts numbers,logs operation and returns the result 
        public double Subtract(double num1, double num2)
        {
            this.Log(" Entered Function Substract: " + "with operands -> " + num1.ToString() + " " + num2.ToString());

            return num1 - num2;


        }
        //performing Division on two double variables,logs operation and returns the result  
        public double Division(double num1, double num2)
        {
            this.Log(" Entered Function Substract: " + "with operands ->" + num1.ToString() + " " + num2.ToString());
            return num1 / num2;
        }

    }
}
