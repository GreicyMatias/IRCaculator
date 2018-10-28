using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRCalculator
{
    public class CalculateIncomeTax
    {
        private double _minimunWage;

        private Rates _rates;

        public CalculateIncomeTax(double minimunWage)
        {
            _minimunWage = minimunWage;

            Initialize();
        }

        public double AmountToPay(double grossIncome, int depentents)
        {
            double netIncome = grossIncome - (_rates.DiscountPerDependent * depentents);
            return (netIncome * _rates.GetAliquot(netIncome)) / 100;
        }

        internal void Initialize()
        {
            _rates = new Rates(_minimunWage);
        }
    }
}
