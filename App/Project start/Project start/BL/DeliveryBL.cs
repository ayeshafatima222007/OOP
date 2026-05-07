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

        public void setDeliveryMethod(string deliveryMethod)
        {
            this.deliveryMethod = deliveryMethod;

            if (deliveryMethod == "Pickup")   // Automatically update cost and address
            {
                this.deliveryCost = 0.0;
                this.deliveryAddress = "N/A";
            }
            else
            {
                this.deliveryCost = 250.0; // Standard charge
            }
        }

        public string getDeliveryAddress()
        {
            return deliveryAddress;
        }

        public void setDeliveryAddress(string address)
        {
            // Only allow setting an address if it's not a Pickup
            if (this.deliveryMethod == "Home Delivery")
            {
                this.deliveryAddress = address;
            }
        }

        public string getDeliveryStatus()
        {
            return deliveryStatus;
        }

        public void setDeliveryStatus(string status)
        {
            this.deliveryStatus = status;
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
