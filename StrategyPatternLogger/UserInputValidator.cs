﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternLogger
{
    internal static class UserInputValidator
    {
        
       public static Calculator ValidateLoggerInput()
        {
            int number = 0;
                do
                {
                    string input = Console.ReadLine();
                    Int32.TryParse(input, out number);
                    switch (number)
                    {
                        case 1:
                            break;

                        case 2:
                            break;
                        default:
                            number = 0;
                            Console.Clear();
                            Console.WriteLine("Please select a valid number for configuration!\n" + "1 - Console logging\n2 - File logging\n\n");
                            continue;
                    }


                } while (number == 0);

            return number == 1 ? new Calculator(new ConsoleLog()) : new Calculator(new FileLog());
        } //Validates user's input and returns a concrete Calculator object with defined behavior.
       public static double ValidateOperand()
        {
            bool isReady = false;
            double d;
            do
            {
                string input = Console.ReadLine();
                if (!Double.TryParse(input.Replace(',', '.'), out d)) {
                    Console.WriteLine("Wrong input,try again!");
                    continue;
                }

                isReady = true;
                break;
            } while (!isReady);

            return d;

        }// Validates user's input and returns legit operand (double) for further operations.

    }
}
