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
            if (!setTaxPercent(taxPercent))
            {
                this.taxPercent = 0;     // Default to 0 if invalid input provided
            }
        }

        public double getTaxPercent()
        {
            return taxPercent;
        }

        public bool setTaxPercent(double taxPercent)
        {
            if (taxPercent >= 0)
            {
                this.taxPercent = taxPercent;
                return true;
            }
            return false;
        }
         
        public double CalculateTax(double total)
        {
            if (total < 0)
            {
                return 0;
            }
            else 
            {
                return (total * taxPercent) / 100;
            }
        }
 
        public double ApplyTax(double total)
        {
            return total + CalculateTax(total);
        }
    }
}
