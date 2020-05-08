using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Console Calculator App! \n" +
                "\nBefore we start, please choose one of the following method for logging " +
                "\nby typing number in front of preferable logging strategy\n");

            Console.WriteLine("1 - Console logging\n" +
                "2 - File logging\n\n");

            Calculator calc = UserInputValidator.ValidateLoggerInput(); //Creating concrete Calculator object with defined behavior upon user valid input. 

            int number = 0;

            do //do-while loop where user is iteratively asked for 1st and 2nd operand + operation on these two. 
            {
                Console.WriteLine(@"*\\\ CONSOLE CALCULATOR ///*");
                Console.WriteLine("\n Write first operand");
                double oper1 = UserInputValidator.ValidateOperand();
                Console.WriteLine("\n Write second operand");
                double oper2 = UserInputValidator.ValidateOperand();

                Console.WriteLine("Select operation: \n 1-Add \n 2-Multiply \n 3-Subtract \n 4-Division");


                string input = Console.ReadLine();
                Int32.TryParse(input, out number);


                switch (number)
                {
                    case 1:
                        Console.WriteLine($"{oper1} + {oper2} = " + calc.Add(oper1, oper2));
                        calc.Log(" Adding succesfull");
                        break;
                    case 2:
                        Console.WriteLine($"{oper1} * {oper2} = " + calc.Multiply(oper1, oper2));
                        calc.Log(" Multipling succesfull");
                        break;
                    case 3:
                        Console.WriteLine($"{oper1} - {oper2} = " + calc.Subtract(oper1, oper2));
                        calc.Log(" Subtracting succesfull");
                        break;
                    case 4:
                        if (oper2 == 0)
                        {
                            calc.Log(" Illegal attempt: Dividing by zero ");
                            Console.WriteLine(" \nPlease provide a different second operand ");
                            break;
                        }
                        Console.WriteLine($"{oper1} / {oper2} = " + calc.Division(oper1, oper2));
                        calc.Log(" Dividing succesfull");
                        break;
                    default:
                        number = 0;
                        Console.Clear();
                        Console.WriteLine("Please select a valid operation!\n" + "1-Add \n 2-Multiply \n 3-Subtract \n 4-Division\n");
                        continue;
                }
                Console.WriteLine("\nAnother operation? \n Y- Another operation \n Any Key - Exit");

                if (Console.ReadKey(false).Key != ConsoleKey.Y)   //on user input ( Y ) we loop again, otherwise we shut down application.
                    break;
                number = 0;

            } while (number == 0);

            calc.Log(" Application ended.");




        }
    }
}
