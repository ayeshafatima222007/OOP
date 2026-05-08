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
        private string category;
        private string name;
        private string color;
        private string size;
        private double price;
        private int quantity;

        public ProductBL(string productId,string category, string name, string color, string size, double price, int quantity)
        {
            setProductId(productId);
            setCategory(category);
            setName(name);
            setColor(color);
            setSize(size);
            setPrice(price);
            setQuantity(quantity);
        }
         
        public String getProductId() 
        {
            return productId;
        }

        public bool setProductId(String productId) 
        {
            if (productId.Length == 0)
            {
                return false;
            }
            this.productId = productId;
            return true;
        }

        public string getCategory()
        {
            return category;
        }

        public bool setCategory(string category)
        {
            if (category == "Casual" || category == "Formal" ||
                category == "Embroidered" || category == "Sports")
            {
                this.category = category;
                return true;
            }
            return false;
        }

        public String getName() 
        { 
            return name;
        }

        public bool setName(String name) 
        {
            if (name.Length == 0)
            {
                return false;
            }

            this.name = name;
            return true;
        }

        public String getColor() 
        {
            return color; 
        }

        public bool setColor(String color) 
        {
            if (color.Length == 0)
            {
                return false;
            }
            this.color = color;
            return true;
        }

        public String getSize() 
        {
            return size;
        }

        public bool setSize(String size) 
        {
            if (size.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < size.Length; i++)
            {
                if (!((size[i] == 'S' || size[i] == 's') || (size[i] == 'M' || size[i] == 'm') || (size[i] == 'L' || size[i] == 'l')))
                {
                    return false;
                }
            }
            this.size = size;
            return true;
        }
         
        public double getPrice() 
        {
            return price;
        }

        public bool setPrice(double price) 
        {
            if (price < 0)
            {
                return false;
            }
            this.price = price;
            return true;
        }

        public int getQuantity() 
        {
            return quantity; 
        }

        public bool setQuantity(int quantity) 
        {
            if (quantity < 0)        //if (quantity == 0)  means the product is out of stock
            {
                return false;
            }
            this.quantity = quantity;
            return true;
        }

    }
}
