using Project_start.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_start.DL
{
    internal class PaymentDL
    {
        public static List<PaymentBL> paymentList = new List<PaymentBL>();
        public static void AddPayment(PaymentBL payment)
        {
            paymentList.Add(payment);
        }

        public static List<PaymentBL> GetAllPayments()
        {
            return paymentList;
        }
         
        public static PaymentBL FindPayment(string paymentId)
        {
            foreach (PaymentBL p in paymentList)
            {
                if (p.getPaymentId() == paymentId)
                {
                    return p;
                }
            }
            return null;
        }
    }
}
