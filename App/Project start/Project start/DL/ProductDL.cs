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

        public static List<ProductBL> FindByCategory(string category)       //easy for buyer
        {
            List<ProductBL> result = new List<ProductBL>();
            foreach (ProductBL p in productList)
            {
                if (p.getCategory() == category)
                {
                    result.Add(p);
                }
            }
            return result;
        }

        public static List<ProductBL> getAllProducts()
        {
            return productList;
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
