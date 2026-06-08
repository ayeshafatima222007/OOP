using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingApp.Library.BL
{

    public class BuyerBL : UserBL
    {
        private string address;
        private CartBL cart;      // Aggregation

        public BuyerBL(string username, string password, string phoneNumber, string address) : base(username, password, phoneNumber, "Buyer")
        {
            this.address = address;
            this.cart = new CartBL("CART_" + username, username);
        }

        public string getAddress()
        {
            return address;
        }
        public void setAddress(string address)
        {
            this.address = address;
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
