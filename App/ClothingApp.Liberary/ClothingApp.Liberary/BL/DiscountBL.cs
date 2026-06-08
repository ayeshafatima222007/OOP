using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingApp.Library.BL
{

    public class DiscountBL
    {
        private string discountCode;
        private double discountPercent;
        private bool isActive;

        public DiscountBL(string discountCode, double discountPercent, bool isActive)
        {
            this.discountCode = discountCode;
            this.discountPercent = discountPercent;
            this.isActive = isActive;
        }

        public string getDiscountCode()
        {
            return discountCode;
        }
        public void setDiscountCode(string discountCode)
        {
            this.discountCode = discountCode;
        }

        public double getDiscountPercent()
        {
            return discountPercent;
        }
        public void setDiscountPercent(double discountPercent)
        {
            this.discountPercent = discountPercent;
        }

        public bool getIsActive()
        {
            return isActive;
        }
        public void setIsActive(bool isActive)
        {
            this.isActive = isActive;
        }
    }
}
