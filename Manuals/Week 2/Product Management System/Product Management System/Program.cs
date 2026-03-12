using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Product_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Product p = new Product();
            /*Create Product class with :
             • ID 
             • Name 
             • Price 
             • Category 
             • Brand 
             • Country
                  Functions: 
             • Add Product 
             • Show Product 
             • Total Store Worth*/
            Console.WriteLine("PRODUCT MANAGEMENT SYSTEM");

            do
            {
                Console.WriteLine("1.Add Product");
                Console.WriteLine("2.Show Product");
                Console.WriteLine("3.Total Store Worth");
                Console.WriteLine("4.Exit\n");

                Console.Write("Enter your choice: ");

                choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    p.AddProduct();
                }
                else if(choice == 2)
                {
                    p.ShowProduct();
                }
                else if (choice == 3)
                {
                    p.TotalStoreWorth();
                }
            } while (choice != 4);


    }
    }
}
