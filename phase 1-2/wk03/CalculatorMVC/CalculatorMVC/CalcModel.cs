using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorMVC
{
    internal class CalcModel
    {
        //properties
        public double UserInput1 { get; set; }
        public double UserInput2 { get; set; }
        public string Operator { get; set; }
        public string EndApp { get; set; }

        //default constructor
        public CalcModel()
        {
            UserInput1 = double.NaN;
            UserInput2 = double.NaN;
            Operator = "";
            EndApp = "";
        }

        //override constructor
        public CalcModel(double input1, double input2, string anOperator, string endOrNot)
        {
            UserInput1 = input1;
            UserInput2 = input2;
            Operator = anOperator;
            EndApp = endOrNot;
        }

        public double CalculateTotal()
        {
            //local variable
            double result = double.NaN;
            
            // Use a switch statement to do the math.
            switch (Operator)
            {
                case "a":
                    result = UserInput1 + UserInput2;
                    break;
                case "s":
                    result = UserInput1 - UserInput2;
                    break;
                case "m":
                    result = UserInput1 * UserInput2;
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor.
                    if (UserInput2 != 0)
                    {
                        result = UserInput1 / UserInput2;
                    }
                    break;
                // Return text for an incorrect option entry.
                default:
                    break;
            }
            return result;
        }

        public bool ContinueOrEnd()
        {
            Console.WriteLine($"EndApp inside model: {EndApp}.");
            if (EndApp == "n")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
