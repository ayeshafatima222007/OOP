using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_start.BL
{
    internal class TaxBL
    {
        private double taxPercent;

        public TaxBL(double taxPercent)
        {
            this.taxPercent = taxPercent;
        }

        public double getTaxPercent()
        {
            return taxPercent;
        }

        public void setTaxPercent(double taxPercent)
        {
            if (taxPercent >= 0)
            {
                this.taxPercent = taxPercent;
            }
        }
         
        public double CalculateTax(double total)
        {
            return (total * taxPercent) / 100;
        }
 
        public double ApplyTax(double total)
        {
            double taxAmount = CalculateTax(total);
            return total + taxAmount;
        }
    }
}
