using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Software
{
    internal class Program
    {
        static List<Product> products = new List<Product>();

        static void Main()
        {

            bool running = true;
            while (running)
            {
                Console.WriteLine("\n╔══════════════════════════════════════╗");
                Console.WriteLine("║   Miss Client's Departmental Store   ║");
                Console.WriteLine("╚══════════════════════════════════════╝");
                Console.WriteLine("  1. Add Product");
                Console.WriteLine("  2. View All Products");
                Console.WriteLine("  3. Find Product with Highest Unit Price");
                Console.WriteLine("  4. View Sales Tax of All Products");
                Console.WriteLine("  5. Products to be Ordered");
                Console.WriteLine("  6. Exit");
                Console.Write("\n  Enter choice: ");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    AddProduct();
                }
                else if (choice == "2")
                {
                    ViewAllProducts();
                }
                else if (choice == "3")
                {
                    FindHighestPriceProduct();
                }
                else if (choice == "4")
                {
                    ViewSalesTax();
                }
                else if (choice == "5")
                {
                    ProductsToBeOrdered();
                }
                else if (choice == "6")
                {
                    running = false;
                }
                else
                {
                    Console.WriteLine("  Invalid choice. Please try again.");
                }
            }

            Console.WriteLine("\n  Goodbye!");
        }

        static void AddProduct()
        {
            Console.WriteLine("\n--- Add Product -----------------------------------");

            Console.Write("  Product Name          : ");
            string name = Console.ReadLine();
            if (name == null || name == "")
            {
                name = "Unknown";
            }

            Console.WriteLine("  Category:");
            Console.WriteLine("    1. Groceries");
            Console.WriteLine("    2. Fresh Fruit");
            Console.Write("  Enter choice          : ");
            string catInput = Console.ReadLine();

            string category = "";
            if (catInput == "1")
            {
                category = "Groceries";
            }
            else if (catInput == "2")
            {
                category = "Fresh Fruit";
            }
            else
            {
                Console.WriteLine("  Invalid category. Defaulting to Groceries.");
                category = "Groceries";
            }

            Console.Write("  Price (Rs.)           : ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.Write("  Stock Quantity        : ");
            int stock = Convert.ToInt32(Console.ReadLine());

            Console.Write("  Min Stock (threshold) : ");
            int minStock = Convert.ToInt32(Console.ReadLine());

            products.Add(new Product(name, category, price, stock, minStock));
            Console.WriteLine("  Product '" + name + "' added successfully.");
        }

        static void ViewAllProducts()
        {
            Console.WriteLine("\n--- View All Products -----------------------------------");

            if (products.Count == 0)
            {
                Console.WriteLine("  No products found.");
                return;
            }

            for (int i = 0; i < products.Count; i++)
            {
                Product p = products[i];
                Console.WriteLine("  Product " + (i + 1) + ":");
                Console.WriteLine("  Product Name          : " + p.Name);
                Console.WriteLine("  Category              : " + p.Category);
                Console.WriteLine("  Price (Rs.)           : " + p.Price.ToString("F2"));
                Console.WriteLine("  Stock Quantity        : " + p.StockQuantity);
                Console.WriteLine("  Min Stock (threshold) : " + p.MinStockQuantity);
                Console.WriteLine();
            }
        }

        static void FindHighestPriceProduct()
        {
            Console.WriteLine("\n--- Find Product with Highest Unit Price -----------------------------------");

            if (products.Count == 0)
            {
                Console.WriteLine("  No products found.");
                return;
            }

            Product highest = products[0];
            for (int i = 1; i < products.Count; i++)
            {
                if (products[i].Price > highest.Price)
                {
                    highest = products[i];
                }
            }

            Console.WriteLine("  Product Name          : " + highest.Name);
            Console.WriteLine("  Category              : " + highest.Category);
            Console.WriteLine("  Price (Rs.)           : " + highest.Price.ToString("F2"));
            Console.WriteLine("  Stock Quantity        : " + highest.StockQuantity);
            Console.WriteLine("  Min Stock (threshold) : " + highest.MinStockQuantity);
        }

        static void ViewSalesTax()
        {
            Console.WriteLine("\n--- View Sales Tax of All Products -----------------------------------");

            if (products.Count == 0)
            {
                Console.WriteLine("  No products found.");
                return;
            }

            for (int i = 0; i < products.Count; i++)
            {
                Product p = products[i];
                Console.WriteLine("  Product " + (i + 1) + ":");
                Console.WriteLine("  Product Name          : " + p.Name);
                Console.WriteLine("  Category              : " + p.Category);
                Console.WriteLine("  Price (Rs.)           : " + p.Price.ToString("F2"));
                Console.WriteLine("  Tax Rate              : " + p.GetTaxRate());
                Console.WriteLine("  Tax Amount (Rs.)      : " + p.GetSalesTax().ToString("F2"));
                Console.WriteLine();
            }
        }

        static void ProductsToBeOrdered()
        {
            Console.WriteLine("\n--- Products to be Ordered (Stock < Min Stock) ---------------------------");

            bool found = false;
            for (int i = 0; i < products.Count; i++)
            {
                Product p = products[i];
                if (p.StockQuantity < p.MinStockQuantity)
                {
                    Console.WriteLine("  Product Name          : " + p.Name);
                    Console.WriteLine("  Category              : " + p.Category);
                    Console.WriteLine("  Price (Rs.)           : " + p.Price.ToString("F2"));
                    Console.WriteLine("  Stock Quantity        : " + p.StockQuantity);
                    Console.WriteLine("  Min Stock (threshold) : " + p.MinStockQuantity);
                    Console.WriteLine();
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("  All products are sufficiently stocked.");
            }
        }
    }
}
