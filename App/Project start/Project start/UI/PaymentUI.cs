using Project_start.BL;
using Project_start.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_start.UI
{
    internal class PaymentUI
    {
        public static void ProcessPayment(OrderBL order)
        {
            CartBL cart = order.getCart();

            if (cart.IsEmpty())
            {
                Console.WriteLine("Cart is empty! Add products first.");
                return;
            }

            Console.WriteLine($"Total amount: {cart.GetTotal()}");

            Console.Write("Enter payment ID: ");
            string paymentId = Console.ReadLine();

            Console.WriteLine("Enter payment method (Cash/Online): ");
            string method = Console.ReadLine();

            double amount = cart.GetTotal();

            PaymentBL payment = new PaymentBL(paymentId, amount, method);
            bool success = payment.ProcessPayment();

            if (success)
            {
                PaymentDL.AddPayment(payment);
                Console.WriteLine("Payment processed successfully!");
            }
            else
            {
                Console.WriteLine("Payment failed!");
            }
        }

        public static void ViewAllPayments()
        {
            var payments = PaymentDL.GetAllPayments();

            if (payments.Count == 0)
            {
                Console.WriteLine("No payments found!");
                return;
            }
            foreach (PaymentBL p in payments)
            {
                Console.WriteLine($"Payment ID: {p.getPaymentId()} | Amount: {p.getAmount()} | Method: {p.getPaymentMethod()} | Paid: {p.getIsPaid()}");
            }
        }
    }
}
