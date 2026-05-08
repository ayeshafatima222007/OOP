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
         
        public double getTaxPercent(string category)           //applying tax based on category
        {
            if (category == "Casual" || category == "Sports")
            {
                return 5;
            }
            else if (category == "Formal")
            {
                return 10;
            }
            else if (category == "Embroidered")
            {
                return 15;
            }
            else
            {
                return 0;
            }
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

        public double CalculateTax(double price, string category)
        {
            if (price < 0)
                return 0;
            return price * getTaxPercent(category) / 100;
        }

        public double ApplyTax(double price, string category)
        {
            return price + CalculateTax(price, category);
        }
         
    }
}
