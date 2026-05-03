using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_start.BL
{
    internal class CartBL
    {
        Queue<ProductBL> productQ = new Queue<ProductBL>();   //FIFO is implemented using Queue

        public void AddToCart(ProductBL p)
        {
            productQ.Enqueue(p);
            //same as productQ.Add(p);
        }

        public double GetTotal()
        {
            double total = 0;
            foreach (ProductBL p in productQ)
            {
                total += p.getPrice();
            }
            return total;
        }

        public ProductBL RemoveFromCart()
        {
            return productQ.Dequeue(); // removes and returns first item (FIFO)
        }
    }
}
