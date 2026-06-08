using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingApp.Library.BL
{

    public class TaxBL
    {
        private string category;
        private double taxPercent;

        public TaxBL(string category, double taxPercent)
        {
            this.category = category;
            this.taxPercent = taxPercent;
        }


        public string getCategory()
        {
            return category;
        }
        public void setCategory(string category)
        {
            this.category = category;
        }

        public double getTaxPercent()
        {
            return taxPercent;
        }
        public void setTaxPercent(double taxPercent)
        {
            this.taxPercent = taxPercent;
        }
    }
}
