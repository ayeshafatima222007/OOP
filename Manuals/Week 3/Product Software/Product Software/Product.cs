using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Software
{
    internal class Product
    {
        public string Name;
        public string Category;
        public double Price;
        public int StockQuantity;
        public int MinStockQuantity;

        // Default Constructor
        public Product()
        {
            Name = "Unknown";
            Category = "Groceries";
            Price = 0.0;
            StockQuantity = 0;
            MinStockQuantity = 0;
        }

        // Parameterized Constructor
        public Product(string name, string category, double price, int stockQty, int minStockQty)
        {
            Name = name;
            Category = category;
            Price = price;
            StockQuantity = stockQty;
            MinStockQuantity = minStockQty;
        }

        // Copy Constructor
        public Product(Product other)
        {
            Name = other.Name;
            Category = other.Category;
            Price = other.Price;
            StockQuantity = other.StockQuantity;
            MinStockQuantity = other.MinStockQuantity;
        }

        public double GetSalesTax()
        {
            if (Category == "Groceries")
            {
                return Price * 0.10;
            }
            else if (Category == "Fresh Fruit")
            {
                return Price * 0.05;
            }
            else
            {
                return Price * 0.15;
            }
        }

        public string GetTaxRate()
        {
            if (Category == "Groceries")
            {
                return "10%";
            }
            else if (Category == "Fresh Fruit")
            {
                return "5%";
            }
            else
            {
                return "15%";
            }
        }
    }
}
