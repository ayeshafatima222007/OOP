using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingApp.Library.BL
{
    public class PaymentBL
    {
        private string paymentId;
        private double amount;
        private string paymentMethod;
        private bool isPaid;
        private string orderId;

        public PaymentBL(string paymentId, string orderId, double amount, string paymentMethod)
        {
            this.paymentId = paymentId;
            this.orderId = orderId;
            this.amount = amount;
            this.paymentMethod = paymentMethod;
            this.isPaid = false;
        }

        public string getOrderId() 
        {
            return orderId; 
        }
        public void setOrderId(string orderId) 
        {
            this.orderId = orderId;
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
            this.amount = amount;
        }

        public string getPaymentMethod()
        {
            return paymentMethod;
        }
        public void setPaymentMethod(string paymentMethod)
        {
            this.paymentMethod = paymentMethod;
        }

        public bool getIsPaid()
        {
            return isPaid;
        }

        public void setIsPaid(bool isPaid)
        {
            this.isPaid = isPaid;
        }
    }
}
