using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_start.BL
{
    internal class DiscountBL
    {
        private string discountCode;
        private double discountPercent;
        private bool isActive;

        public DiscountBL(string discountCode, double discountPercent,bool isActive)
        {
            this.discountCode = discountCode;
            this.discountPercent = discountPercent;
            this.isActive = isActive;
        }

        public bool ValidateCode(string enteredCode)     //discount code enter by seller is handled by DiscountDL class
        {
            if ((enteredCode == discountCode) && (isActive == true))
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public double ApplyDiscount(double total)
        {
            double discountAmount = total * discountPercent / 100;
            return total - discountAmount;
        }
    }
}
