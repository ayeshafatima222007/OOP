using Project_start.BL;
using Project_start.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_start.UI
{
    internal class DeliveryUI
    {
        public static void AddDelivery()
        {
            Console.WriteLine("Enter delivery method (Pickup/Home Delivery): ");
            string method = Console.ReadLine();

            DeliveryBL delivery;

            if (method == "Home Delivery")
            {
                Console.Write("Enter delivery address: ");
                string address = Console.ReadLine();
                delivery = new DeliveryBL(method, address);
            }
            else
            {
                delivery = new DeliveryBL(method);
            }

            DeliveryDL.AddDelivery(delivery);
            Console.WriteLine($"Delivery added!");
            Console.WriteLine($"Cost: {delivery.getDeliveryCost()}");
        }

        public static void ViewAllDeliveries()
        {
            var deliveries = DeliveryDL.GetAllDeliveries();

            if (deliveries.Count == 0)
            {
                Console.WriteLine("No deliveries found!");
                return;
            }

            foreach (DeliveryBL d in deliveries)
            {
                Console.WriteLine($"Method: {d.getDeliveryMethod()} | Address: {d.getDeliveryAddress()} | Status: {d.getDeliveryStatus()} | Cost: {d.getDeliveryCost()}");
            }
        }
    }
}
