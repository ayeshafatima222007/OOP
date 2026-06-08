using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingApp.Library.BL
{
    public class DeliveryBL
    {
        private string deliveryMethod;
        private string deliveryAddress;
        private string deliveryStatus;
        private double deliveryCost;
        private string deliveryId;
        private string orderId;

        // in constructor
        public DeliveryBL(string deliveryId, string orderId, string deliveryMethod, string deliveryAddress, double deliveryCost)
        {
            this.deliveryId = deliveryId;
            this.orderId = orderId;
            this.deliveryMethod = deliveryMethod;
            this.deliveryAddress = deliveryAddress;
            this.deliveryCost = deliveryCost;
            this.deliveryStatus = "Pending";
        }

        public string getOrderId() { return orderId; }
        public void setOrderId(string orderId) { this.orderId = orderId; }

        public string getDeliveryId()
        {
            return deliveryId;
        }
        public void setDeliveryId(string deliveryId) 
        {
            this.deliveryId = deliveryId; 
        }
        public string getDeliveryMethod()
        {
            return deliveryMethod;
        }
        public void setDeliveryMethod(string deliveryMethod)
        {
            this.deliveryMethod = deliveryMethod;
        }

        public string getDeliveryAddress()
        {
            return deliveryAddress;
        }
        public void setDeliveryAddress(string deliveryAddress)
        {
            this.deliveryAddress = deliveryAddress;
        }

        public string getDeliveryStatus()
        {
            return deliveryStatus;
        }
        public void setDeliveryStatus(string deliveryStatus)
        {
            this.deliveryStatus = deliveryStatus;
        }

        public double getDeliveryCost()
        {
            return deliveryCost;
        }
        public void setDeliveryCost(double deliveryCost)
        {
            this.deliveryCost = deliveryCost;
        }
    }
}
