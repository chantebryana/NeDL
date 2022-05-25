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
            //local variable that flags whether to continue or quit the app
            bool endApp = false;

            while (!endApp)
            {
                calcView = new CalcView();
                calcModel = new CalcModel(calcView.UserInput1, calcView.UserInput2, calcView.Operator, calcView.EndApp);
                calcView.Result = calcModel.CalculateTotal();
                calcView.ShowCalculation();
                calcView.ContinueOrQuit();
                endApp = calcModel.ContinueOrEnd();
                Console.Write(endApp);
            }

        }

    }
}
