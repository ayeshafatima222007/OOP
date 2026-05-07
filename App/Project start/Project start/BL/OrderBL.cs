using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Project_start.BL
{
    internal class OrderBL
    {
        private string orderId;
        private string status;
        private DateTime orderDate;
        private BuyerBL buyer;                    //aggregation
        private CartBL cart = new CartBL();      // composition

        public OrderBL(string orderId, BuyerBL buyer) //date time is not passes in parameters bcz it is auto set
        {
            setOrderId(orderId);
            setBuyer(buyer);                 // aggregation 
            this.cart = new CartBL();       // composition 
            this.orderDate = DateTime.Now; // auto set
            this.status = "Pending";      // default status
        }

        public string getOrderId()
        {
            return orderId;
        }

        public bool setOrderId(string orderId)
        {
            if (orderId.Length == 0)
            {
                return false;
            }
            this.orderId = orderId;
            return true;
        }
        public string getStatus()
        {
            return status;
        }

        public bool setStatus(string status)
        {
            if (status == "Pending" || status == "Delivered" || status == "Cancelled")
            {
                this.status = status;
                return true;
            }
            return false;
        }

        public DateTime getOrderDate()
        {
            return orderDate;
        }

        public void setOrderDate(DateTime orderDate)
        {
            this.orderDate = orderDate;
        }

        public BuyerBL getBuyer()
        {
            return buyer;
        }

        public bool setBuyer(BuyerBL buyer)
        {
            if (buyer == null)
            {
                return false;
            }
            this.buyer = buyer;
            return true;
        }

        public CartBL getCart()
        {
            return cart;
        }

        public void setCart(CartBL cart)
        {
            this.cart = cart;
        }
    }
}
