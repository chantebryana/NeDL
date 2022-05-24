using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorMVC
{
    internal class CalcController
    {
        //private variables
        private CalcModel calcModel;
        private CalcView calcView;

        //constructor
        //instantiate View and Model
        public CalcController ()
        {
            calcView = new CalcView ();
            calcModel = new CalcModel(calcView.UserInput1, calcView.UserInput2, calcView.Operator);
            calcView.Result = calcModel.CalculateTotal();
            calcView.ShowCalculation();

        }

    }
}
