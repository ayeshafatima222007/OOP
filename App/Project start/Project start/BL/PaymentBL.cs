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
            this.paymentId = paymentId;
            this.amount = amount;
            this.paymentMethod = paymentMethod;
            this.isPaid = false; // Default to unpaid
        }
 
        public string getPaymentId()
        {
            return paymentId;
        }

        public void setPaymentId(string paymentId)
        {
            this.paymentId = paymentId;
        }

        public double getAmount()
        {
            return amount;
        }

        public void setAmount(double amount)
        {
            // Simple validation: amount shouldn't be negative
            if (amount >= 0)
            {
                this.amount = amount;
            }
        }

        public string getPaymentMethod()
        {
            return paymentMethod;
        }

        public void setPaymentMethod(string paymentMethod)
        {
            // Ensuring only specific values are used
            if (paymentMethod == "Cash" || paymentMethod == "Online")
            {
                this.paymentMethod = paymentMethod;
            }
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
