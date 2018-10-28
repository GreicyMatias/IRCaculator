using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRCalculator
{
    public class Rates
    {
        private double _minimumWage;

        private double _discountPerDependent;
        public double DiscountPerDependent
        {
            get
            {
                return _discountPerDependent;
            }
        }

        public Rates(double minimunWage) //salario minimo
        {
            _minimumWage = minimunWage;

            SetValueDiscountPerDependent();
        }

        public double GetAliquot(double netIncome) //renda liquida
        {
            var result = AmountOfWages(netIncome);

            if (result <= 2)
                return 0;

            if (result <= 4)
                return 7.5;

            if (result <= 5)
                return 15;

            if (result <= 7)
                return 22.5;

            return 27.5;
        }

        public void SetValueDiscountPerDependent()
        {
            _discountPerDependent = (5 * _minimumWage) / 100;
        }

        internal double AmountOfWages(double netIncome)
        {
            return (netIncome / _minimumWage);
        }
    }
}
