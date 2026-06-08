using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingApp.Library.BL
{
    public class OrderBL
    {
        private string orderId;
        private string status;
        private DateTime orderDate;
        private BuyerBL buyer;      // Aggregation
        private CartBL cart;        // Composition

        public OrderBL(string orderId, BuyerBL buyer)
        {
            this.orderId = orderId;
            this.buyer = buyer;
            this.cart = new CartBL(orderId, buyer.getUsername());  // Composition
            this.orderDate = DateTime.Now;
            this.status = "Pending";
        }


        public string getOrderId()           //--- orderId ---
        {
            return orderId;
        }
        public void setOrderId(string orderId)
        {
            this.orderId = orderId;
        }

        public string getStatus()          //--- status ---
        {
            return status;
        }
        public void setStatus(string status)
        {
            this.status = status;
        }


        public DateTime getOrderDate()           // --- orderDate ---
        {
            return orderDate;
        }
        public void setOrderDate(DateTime orderDate)
        {
            this.orderDate = orderDate;
        }


        public BuyerBL getBuyer()                    // --- buyer ---
        {
            return buyer;
        }
        public void setBuyer(BuyerBL buyer)
        {
            this.buyer = buyer;
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
