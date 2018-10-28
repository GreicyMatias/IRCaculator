using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRConsole.Models
{
    public class Taxpayer
    {
        public string CPF { get; set; }
        public string Name { get; set; }
        public int NumberOfDependents { get; set; }
        public double GrossIncome { get; set; }
        public double AmountToPay { get; set; }


        public override string ToString()
        {
            return Name + " - " + AmountToPay.ToString("C");
        }
    }
}
