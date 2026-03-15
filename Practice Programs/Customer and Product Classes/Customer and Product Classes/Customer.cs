using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_and_Product_Classes
{
    internal class Customer
    {
        public string CustomerName;
        public string CustomerAddress;
        public string CustomerCity;

        public List<Product>prod = new List<Product>();
        public List<Product> getAllproduct()
        {
            return prod;
        }

        public void addProduct(Product product)
        {
            prod.Add(product);
        }
    }
}
