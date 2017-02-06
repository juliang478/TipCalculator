using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculator
{
    class Calculations
    {
        private const double tip15Percent = .15;
        private const double tip20percent = .20;
       

        public double Calculate15PercentTip(double billAmount)
        {
            return billAmount * tip15Percent;
        }

        public double Calculate20PercentTip(double billAmount)
        {
            return billAmount * tip20percent;
        }

        public double CalculateBill(double billAmount, double tipAmount)
        {
            return billAmount + tipAmount;
        }
    }
}
