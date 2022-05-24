using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipMVC
{
    internal class TipCalcController
    {
        ///

        ///The TipCalController class brings together
        ///the display and the tip or model classes.
        ///I use the constructor to instantiate the Display.
        ///Instantiating the Display calls its constructor
        ///which calls the Get input method
        ///Once the input is entered I can instantiate
        ///the Tip class and pass the values from the
        ///Dipslay class. Notice the dot notation and observe
        ///how the two classes interact.

        ///

        private TipModel tipModel;
        private TipView tipView;

        public TipCalcController()
        {
            tipView = new TipView();
            tipModel = new TipModel(tipView.Amt, tipView.Percentage);
            tipView.TipAmount = tipModel.CalculateTip();
            tipView.Total = tipModel.CalculateTotal();
            tipView.ShowTipandTotal();
        }
    }
}
