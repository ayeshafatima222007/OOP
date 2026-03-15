using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_and_Product_Classes
{
    internal class Product
    {
        public string ProductName;
        public float ProductPrice;
        public string Category;

        public float CalculateTax()
        {
            return ProductPrice * 0.1f; 
        }
    }
}
