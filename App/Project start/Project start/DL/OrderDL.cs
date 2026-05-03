using Project_start.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_start.DL
{
    internal class OrderDL
    {
        public static List<OrderBL> orderList = new List<OrderBL>();

        public static void AddOrder(OrderBL ord)
        {
            orderList.Add(ord);
        }

        public static OrderBL FindOrder(string orderId)
        {
            foreach (OrderBL ord in orderList)
            {
                if (ord.getOrderId() == orderId)
                {
                    return ord;     //found
                }
            }
            return null;      //not found
        }

        public static void ViewAllOrders()
        {
            if (orderList.Count == 0)
            {
                Console.WriteLine("No orders available!");
                return;
            }

            Console.WriteLine("================================================================================");
            Console.WriteLine($"{"ID",-10}{"Status",-20}{"Order Date",-12}{"Buyer",-8}{"Price",-12}{"Quantity",-10}");
            Console.WriteLine("================================================================================");

            foreach (ProductBL p in productList)
            {
                Console.WriteLine($"{p.getProductId(),-10}{p.getName(),-20}{p.getColor(),-12}{p.getSize(),-8}{p.getPrice(),-12}{p.getQuantity(),-10}");
            }

            Console.WriteLine("================================================================================");
        }
    }
}
