using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingApp.Library.BL
{
    public class CartBL
    {
        private string cartId;
        private string buyerId;          //because the cart have to link with buyer so there is aggregation between CartBL and BuyerBL
        private Queue<ProductBL> productQ = new Queue<ProductBL>();

        public CartBL(string cartId, string buyerId)
        {
            this.cartId = cartId;
            this.buyerId = buyerId;
        }

        public string getCartId()
        {
            return cartId;
        }
        public void setCartId(string cartId)
        {
            this.cartId = cartId;
        }

        public string getBuyerId()
        {
            return buyerId;
        }
        public void setBuyerId(string buyerId)
        {
            this.buyerId = buyerId;
        }

        public void AddToCart(ProductBL product)
        {
            productQ.Enqueue(product);      //same as productQ.Add(p) but it add new item in end
        }
        public ProductBL RemoveFromCart()
        {
            return productQ.Dequeue();
        }
        public Queue<ProductBL> GetCartItems()
        {
            return productQ;
        }
        public bool IsEmpty()
        {
            return productQ.Count == 0;
        }
        public void ClearCart()
        {
            productQ.Clear();
        }
    }
}
