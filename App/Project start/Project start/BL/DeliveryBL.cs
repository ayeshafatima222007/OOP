using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_start.BL
{
    internal class DeliveryBL
    {
        private string deliveryMethod; 
        private string deliveryAddress;
        private string deliveryStatus; 
        private double deliveryCost;

        public DeliveryBL(string deliveryMethod, string deliveryAddress = "")
        {
            setDeliveryMethod(deliveryMethod);
            this.deliveryStatus = "Pending"; 

            //  Pickup vs Home Delivery
            if (deliveryMethod == "Pickup")
            {
                this.deliveryAddress = "N/A";
                this.deliveryCost = 0.0;
            }
            else
            {
                setDeliveryAddress(deliveryAddress);
                this.deliveryCost = 250.0; // fix rate for Home Delivery
            }
        }

        public string getDeliveryMethod()
        {
            return deliveryMethod;
        }

        public bool setDeliveryMethod(string deliveryMethod)
        {
            if (deliveryMethod == "Pickup" || deliveryMethod == "Home Delivery")
            {
                this.deliveryMethod = deliveryMethod;
                return true;
            }
            return false;
        }

        public string getDeliveryAddress()
        {
            return deliveryAddress;
        }

        public bool setDeliveryAddress(string address)
        {
            if (deliveryMethod == "Home Delivery" && address.Length > 0)
            {
                this.deliveryAddress = address;
                return true;
            }
            return false;
        }

        public string getDeliveryStatus()
        {
            return deliveryStatus;
        }

        public bool setDeliveryStatus(string status)
        {
            if (status == "Pending" || status == "Delivered" || status == "Cancelled")
            {
                this.deliveryStatus = status;
                return true;
            }
            return false;
        }
        public double getDeliveryCost()
        {
            return deliveryCost;
        }

        public void setDeliveryCost(double cost)
        {
            if (deliveryMethod == "Pickup")
            {
                deliveryCost = 0; // Pickup is always free
            }
            else
            {
                deliveryCost = cost; // Home Delivery has a cost
            }
        }
    }
}
