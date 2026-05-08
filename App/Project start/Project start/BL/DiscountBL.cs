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
            setDiscountCode(discountCode);
            setDiscountPercent(discountPercent);
            this.isActive = isActive;
        }

        public string getDiscountCode()
        {
            return discountCode;
        }

        public bool setDiscountCode(string discountCode)
        {
            if (discountCode.Length == 0)
            {
                return false;
            }
            this.discountCode = discountCode;
            return true;
        }

        public double getDiscountPercent()
        {
            return discountPercent;
        }

        public bool setDiscountPercent(double discountPercent)
        {
            if (discountPercent >= 5 && discountPercent <= 50)     // 5-50% discount
            {
                this.discountPercent = discountPercent;
                return true;
            }

            // If invalid,don't update the value
            return false;
        }

        public bool getIsActive()
        {
            return isActive;
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
