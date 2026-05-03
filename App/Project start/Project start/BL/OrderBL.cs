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
        private BuyerBL buyer;  //aggregation
        private CartBL cart = new CartBL(); // composition

        public OrderBL(string orderId, BuyerBL buyer) //date time is not passes in parameters bcz it is auto set
        {
            this.orderId = orderId;
            this.buyer = buyer;        // aggregation 
            this.cart = new CartBL();  // composition 
            this.orderDate = DateTime.Now; // auto set
            this.status = "Pending";   // default status
        }

        public string getOrderId()
        {
            return orderId;
        }

        public void setOrderId(string orderId)
        {
            this.orderId = orderId;
        }
        public string getStatus()
        {
            return status;
        }

        public void setStatus(string status)
        {
            this.status = status;
        }

        public DateTime getOrderDate()
        {
            return orderDate;
        }

        public void SetOrderDate(DateTime orderDate)
        {
            this.orderDate = orderDate;
        }

        public BuyerBL getBuyer()
        {
            return buyer;
        }

        public void setBuyer(BuyerBL buyer)
        {
            this.buyer = buyer;
        }

        public CartBL GetCart()
        {
            return cart;
        }

        public void SetCart(CartBL cart)
        {
            this.cart = cart;
        }
    }
}
