using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Departmental_Store
{
    internal class Customer
    {
        public string CustomerName;
        public List<Product> CartProduct;
        public List<int> CartQty;

        public Customer(string CustomerName)
        {
            this.CustomerName = CustomerName;

            this.CartProduct = new List<Product>();
            this.CartQty = new List<int>();
        }
    }
}
