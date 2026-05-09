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

        public static List<PaymentBL> FindPayment(string username)
        {
            List<OrderBL> result = new List<OrderBL>();
            foreach (PaymentBL p in paymentList)
            {
                if (o.getBuyer().getUsername() == username)
                {
                    result.Add(p);
                }
            }
            return result;
        }
    }
}
