using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Customer_and_Product_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer();

            c.CustomerName = "Ali";
            c.CustomerAddress = "Lahore";
            c.CustomerCity = "LHR";

            Product p1 = new Product();
            p1.ProductName = "Milk";
            p1.Category = "Grocery";
            p1.ProductPrice = 100;

            Product p2 = new Product();
            p2.ProductName = "Bread";
            p2.Category = "Grocery";
            p2.ProductPrice = 80;

            c.addProduct(p1);
            c.addProduct(p2);


            List<Product> list = c.getAllproduct();

            foreach (Product p in list) 
            {
                Console.WriteLine($"Product Name: {p.ProductName}");
                Console.WriteLine($"Category: {p.Category}");
                Console.WriteLine($"Price: {p.ProductPrice }");
                Console.WriteLine($"Tax: {p.CalculateTax()}");
                Console.WriteLine();
            }
        }
    }
}
