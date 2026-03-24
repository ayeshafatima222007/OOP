using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Departmental_Store
{
    internal class Product
    {
        public string ProdName;
        public string Category;
        public double ProdPrice;
        public int ProdQty;
        public int MinThershold;
        public static List<Product> ProductList = new List<Product>();

        public Product(string ProdName, string Category, double ProdPrice, int ProdQty, int MinThershold)
        {
            this.ProdName = ProdName;
            this.Category = Category;
            this.ProdPrice = ProdPrice;
            this.ProdQty = ProdQty;
            this.MinThershold = MinThershold;
        }

        public static void AddProduct()
        {
            Console.Write("Enter the name of the product:");
            string name = Console.ReadLine();

            Console.Write("Enter the category of the product:");
            string category = Console.ReadLine();


            double price;         //input price

            while (true)
            {
                Console.Write("Enter the price of the product:");
                if (double.TryParse(Console.ReadLine(), out price))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Enter Valid Number!!");
                }
            }


            int Qty;           //input quantity

            while (true)
            {
                Console.Write("Enter the quantity of the product:");
                if (int.TryParse(Console.ReadLine(), out Qty))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Enter Valid Number!!");
                }
            }


            int threshold;          //input minimun threshold

            while (true)
            {
                Console.Write("Enter the minimum Thershold of the product:");
                if (int.TryParse(Console.ReadLine(), out threshold))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Enter Valid Number!!");
                }
            }

            Product p = new Product(name, category, price, Qty, threshold);

            ProductList.Add(p);
        }

        static void ViewAllProducts()
        {
            if (ProductList.Count == 0)
            {
                Console.WriteLine("No Product Found");
            }
            else
            {
                foreach (Product p in ProductList)
                {
                    Console.WriteLine($"Product Name: {p.ProdName}");
                    Console.WriteLine($"Product Cateogry: {p.Category}");
                    Console.WriteLine($"Product Price: {p.ProdPrice}");
                    Console.WriteLine($"Product Quantity: {p.ProdQty} ");
                    Console.WriteLine($"Product Min Threshold: {p.MinThershold}");

                }
            }
        }
    }
}
