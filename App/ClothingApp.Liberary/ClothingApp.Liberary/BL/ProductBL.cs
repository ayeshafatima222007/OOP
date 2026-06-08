using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingApp.Library.BL
{

    public class ProductBL
    {
        private string productId;
        private string category;
        private string name;
        private string color;
        private string size;
        private double price;
        private int quantity;

        public ProductBL(string productId, string category, string name, string color, string size, double price, int quantity)
        {
            this.productId = productId;
            this.category = category;
            this.name = name;
            this.color = color;
            this.size = size;
            this.price = price;
            this.quantity = quantity;
        }

        public string getProductId()
        {
            return productId;
        }

        public void setProductId(string productId)
        {
            this.productId = productId;
        }

        public string getCategory()
        {
            return category;
        }

        public void setCategory(string category)
        {
            this.category = category;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getColor()
        {
            return color;
        }

        public void setColor(string color)
        {
            this.color = color;
        }

        public string getSize()
        {
            return size;
        }

        public void setSize(string size)
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
