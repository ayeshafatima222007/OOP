using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_start.BL
{
    internal class ProductBL
    {
        private string productId;
        private string name;
        private string color;
        private string size;
        private double price;
        private int quantity;

        public ProductBL(string productId, string name, string color, string size, double price, int quantity)
        {
            this.productId = productId;
            this.name = name;
            this.color = color;
            this.size = size;
            this.price = price;
            this.quantity = quantity;
        }
         
        public String getProductId() 
        {
            return productId;
        }

        public void setProductId(String productId) 
        {
            this.productId = productId; 
        }

        public String getName() 
        { 
            return name;
        }

        public void setName(String name) 
        {
            this.name = name; 
        }

        public String getColor() 
        {
            return color; 
        }

        public void setColor(String color) 
        {
            this.color = color; 
        }

        public String getSize() 
        {
            return size;
        }

        public void setSize(String size) 
        {
            this.size = size;
        }
         
        public double getPrice() 
        {
            return price;
        }

        public void setPrice(double price) 
        {
            this.price = price; 
        }

        public int getQuantity() 
        {
            return quantity; 
        }

        public void setQuantity(int quantity) 
        {
            this.quantity = quantity; 
        }

    }
}
