using System;
using System.Collections.Generic;
using System.IO;
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

        public static void ViewAllProducts()
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

        public static void FindHighestPrice()
        {
            if (ProductList.Count == 0)
            {
                Console.WriteLine("No Product Found");
            }
            else
            {
                Product highest = ProductList[0];     //assuming first element has highest price
                foreach (Product p in ProductList)
                {
                    if (p.ProdPrice > highest.ProdPrice)
                    {
                        highest = p;        //store whole product obj
                    }
                }
                Console.WriteLine("Product with Highest Price:");
                Console.WriteLine($"Product Name: {highest.ProdName}");
                Console.WriteLine($"Product Category: {highest.Category}");
                Console.WriteLine($"Product Price: {highest.ProdPrice}");
                Console.WriteLine($"Product Quantity: {highest.ProdQty}");
                Console.WriteLine($"Product Min Threshold: {highest.MinThershold}");
            }   
        }

        public static void ViewSalesTax()
        {
            if (ProductList.Count == 0)
            {
                Console.WriteLine("No Product Found");
            }
            else
            {
                foreach(Product p in ProductList)
                {
                    double tax = 0;
                    if (p.Category == "Grocery")
                    {
                        tax = p.ProdPrice * 0.10;  //10% tax
                    }
                    else if (p.Category == "Fruit")
                    {
                        tax = p.ProdPrice * 0.05;    //5% tax
                    }
                    else
                    {
                        tax = p.ProdPrice * 0.15;    //15% tax
                    }
                    Console.WriteLine($"Product Name: {p.ProdName}");
                    Console.WriteLine($"Category: {p.Category}");
                    Console.WriteLine($"Price: {p.ProdPrice}");
                    Console.WriteLine($"Sales Tax: {tax}");
                    Console.WriteLine("---------------------------");
                }
            }
        }

        public static void ProductToBeOrdered()
        {
            if (ProductList.Count == 0)
            {
                Console.WriteLine("No Product Found");
            }
            else
            {
                foreach (Product p in ProductList)
                {
                    if (p.ProdQty <p.MinThershold)
                    {
                        Console.WriteLine($"Product Name: {p.ProdName}");
                        Console.WriteLine($"Category: {p.Category}");
                        Console.WriteLine($"Price: {p.ProdPrice}");
                        Console.WriteLine("---------------------------");
                    }
                }
            }
        }
    }
}
