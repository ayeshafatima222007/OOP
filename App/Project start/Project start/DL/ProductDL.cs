using Project_start.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_start.DL
{
    internal class ProductDL
    {
        public static List<ProductBL> productList = new List<ProductBL>();

        public static void AddProduct(ProductBL prod)
        {
            productList.Add(prod);
        }

        public static ProductBL FindProduct(string ID)
        {
            foreach (ProductBL prod in productList)
            {
                if (prod.getProductId() == ID)
                {
                    return prod;     //found
                }
            }
            return null;      //not found
        }

        public static void ViewAllProducts()
        {
            if (productList.Count == 0)
            {
                Console.WriteLine("No products available!");
                return;
            }

            Console.WriteLine("================================================================================");
            Console.WriteLine($"{"ID",-10}{"Name",-20}{"Color",-12}{"Size",-8}{"Price",-12}{"Quantity",-10}");
            Console.WriteLine("================================================================================");

            foreach (ProductBL p in productList)
            {
                Console.WriteLine($"{p.getProductId(),-10}{p.getName(),-20}{p.getColor(),-12}{p.getSize(),-8}{p.getPrice(),-12}{p.getQuantity(),-10}");
            }

            Console.WriteLine("================================================================================");
        }

        public static void DelProduct(string ID)
        {
            foreach (ProductBL prod in productList)
            {
                if (prod.getProductId() == ID)
                {
                    productList.Remove(prod);   //stop loop after remove
                    break;
                }
            }
        }

        public static void UpdateProduct(string productId, ProductBL updatedProduct)
        {
            for (int i = 0; i < productList.Count; i++)
            {
                if (productList[i].getProductId() == productId)
                {
                    productList[i] = updatedProduct ; // replace with updatedProduct
                    break;
                }
            }
        }
    }
}
