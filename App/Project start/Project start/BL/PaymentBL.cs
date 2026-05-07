using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_start.BL
{
    internal class PaymentBL
    {
        private string paymentId;
        private double amount;
        private string paymentMethod;
        private bool isPaid;

        public PaymentBL(string paymentId, double amount, string paymentMethod)
        {
            setPaymentId(paymentId);
            setAmount(amount);
            setPaymentMethod(paymentMethod);
            this.isPaid = false; // Default to unpaid
        }
 
        public string getPaymentId()
        {
            return paymentId;
        }

        public bool setPaymentId(string paymentId)
        {
            if (paymentId.Length == 0)
            {
                return false;
            }
            this.paymentId = paymentId;
            return true;
        }

        public double getAmount()
        {
            return amount;
        }

        public bool setAmount(double amount)
        {
            // Simple validation: amount shouldn't be negative
            if (amount >= 0)
            {
                this.amount = amount;
                return true;
            }
            return false;
        }

        public string getPaymentMethod()
        {
            return paymentMethod;
        }

        public bool setPaymentMethod(string paymentMethod)
        {
            // Ensuring only specific values are used
            if (paymentMethod == "Cash" || paymentMethod == "Online")
            {
                this.paymentMethod = paymentMethod;
                return true;
            }
            return false;
        }

        public bool getIsPaid()
        {
            return isPaid;
        }

        public void SetIsPaid(bool isPaid)
        {
            this.isPaid = isPaid;
        }

        public bool ProcessPayment()
        {
            isPaid = true;
            return isPaid;
        }

    }
}
