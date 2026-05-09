using Project_start.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_start.DL
{
    internal class DeliveryDL
    {
        public static List<DeliveryBL> deliveryList = new List<DeliveryBL>();
        public static void AddDelivery(DeliveryBL delivery)
        {
            deliveryList.Add(delivery);
        }

        public static List<DeliveryBL> GetAllDeliveries()
        {
            return deliveryList;
        }
    }
}
