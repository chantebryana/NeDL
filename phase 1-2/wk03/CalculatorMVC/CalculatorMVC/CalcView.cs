using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorMVC
{
    internal class CalcView
    {
        //properties
        public double UserInput1 { get; set; }
        public double UserInput2 { get; set; }
        public string Operator { get; set; }
        public double Result { get; set; }

        //constructor
        public CalcView()
        {
            UserInput1 = double.NaN;
            UserInput2 = double.NaN;
            Operator = "";
            Result = double.NaN;
            GetValues();
        }

        //private method for getting input
        //it is called in the constructor
        private void GetValues()
        {
            Console.Write("Type a number, and then press Enter:");
            UserInput1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Type another number, and then press Enter:");
            UserInput2 = Convert.ToDouble(Console.ReadLine());

            // Ask the user to choose an operator.
            Console.WriteLine("Choose an operator from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option? ");

            Operator = (Console.ReadLine()).ToLower();
        }

        //public method to show output
        //public so I can access it from the controller
        public void ShowCalculation ()
        {
            Console.WriteLine("Your result: {0:0.##}", Result);
        }
    }
}
