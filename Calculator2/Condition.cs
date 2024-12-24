using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2
{
    internal class Condition
    {
        public static bool CheckCondition(string symbol)
        {
            switch (symbol)
            {
                case "s":
                    Calculator.Sqrt();
                    return false;
                case "c":
                    Console.Clear();
                    Calculator.Result = 0;
                    return true;
                case "e":
                    Environment.Exit(0);
                    return false;
                default:
                    return false;
            }
        }

        public static bool CheckCondition(string symbol, double valueSecond) 
        {
            switch (symbol)
            {
                case "+":
                    Calculator.Summary(valueSecond);
                    return true;
                case "-":
                    Calculator.Difference(valueSecond);
                    return true;
                case "*":
                    Calculator.Multiplication(valueSecond);
                    return true;
                case "/":
                    if (valueSecond == 0)
                        return false;
                    else
                    {
                        Calculator.Division(valueSecond);
                        return true;
                    }
                case "%":
                    Calculator.Percent(valueSecond);
                    return true;
                case "p":
                    Calculator.Power(valueSecond);
                    return true;
                default:
                    return true;
            }
        }
    }
}
