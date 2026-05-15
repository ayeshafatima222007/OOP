using Project_start.BL;
using Project_start.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_start.UI
{
    internal class DiscountUI
    {
        public static void AddDiscount()
        {
            Console.Write("Enter discount code: ");
            string code = Console.ReadLine();

            Console.Write("Enter discount percent (5-50): ");
            double percent = double.Parse(Console.ReadLine());

            Console.Write("Discount is applied or not: ");
            bool isActive = bool.Parse(Console.ReadLine());

            DiscountBL discount = new DiscountBL(code, percent, isActive);
            DiscountDL.AddDiscount(discount);

            Console.WriteLine("Discount added successfully!");
        }

        public static void ApplyDiscount(OrderBL order)
        {
            Console.Write("Enter discount code: ");
            string code = Console.ReadLine();

            DiscountBL discount = DiscountDL.FindDiscount(code);
            if (discount == null)
            {
                Console.WriteLine("Invalid or inactive discount code!");
                return;
            }

            double total = order.getCart().GetTotal();
            double discountedTotal = discount.ApplyDiscount(total);

            Console.WriteLine($"Original Total: {total}");
            Console.WriteLine($"Discounted Total: {discountedTotal}");
        }

        public static void ViewAllDiscounts()
        {
            var discounts = DiscountDL.getAllDiscounts();

            if (discounts.Count == 0)
            {
                Console.WriteLine("No discounts found!");
                return;
            }

            foreach (DiscountBL d in discounts)
            {
                Console.WriteLine($"Code: {d.getDiscountCode()} | Percent: {d.getDiscountPercent()}% | Active: {d.getIsActive()}");
            }
        }

    }
}
