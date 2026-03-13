using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Tax
{
    internal class Product
    {
        public string name;
        public string category;
        public int price;
        public int stock;
        public int minimumStock;

        public float calculateTax()
        {
            float tax;
            if (category == "Grocery")
            {
                tax = price * 10 / 100F;
            }
            else if (category == "Fruit")
            {
                tax = price * 5 / 100F;
            }
            else
            {
                tax = price * 15 / 100F;
            }
            return tax;
        }
    }
}
