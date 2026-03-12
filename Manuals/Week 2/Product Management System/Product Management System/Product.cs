using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Management_System
{
    internal class Product
    {
        int count;
        string []ID = new string[50];
        string []Name = new string[50];
        double[] Price = new double[50];
        string[] Category = new string[50];
        string[] Brand = new string[50];
        string[] Country = new string[50];

        public void AddProduct()
        {
            Console.Write("Enter Product ID: ");
            ID[count] = Console.ReadLine();

            Console.Write("Enter Product Name: ");
            Name[count] = Console.ReadLine();

            Console.Write("Enter Product Price: ");
            Price[count] = double.Parse(Console.ReadLine());

            Console.Write("Enter Product Category: ");
            Category[count] = Console.ReadLine();

            Console.Write("Enter Product Brand: ");
            Brand[count] = Console.ReadLine();

            Console.Write("Enter Product Country: ");
            Country[count] = Console.ReadLine();

            Console.WriteLine();

            count++;
        }

        public void ShowProduct() 
        {
            if (count==0)
            {
                Console.WriteLine("No Product Found!!!");
            }
            else
            {
                string SearchID = Console.ReadLine();
                for (int i=0;i<count;i++)
                {
                    if (SearchID == ID[i])
                    
                    Console.WriteLine($"Product Name: {Name[i]}");
                    Console.WriteLine($"Product Price: {Price[i]}");
                    Console.WriteLine($"Product Category: {Category[i]}");
                    Console.WriteLine($"Product Brand: {Brand[i]}");
                    Console.WriteLine($"Product Country: {Country[i]}\n\n");
                }
            }
        }

        public void TotalStoreWorth()
        {
            if (count == 0)
            {
                Console.WriteLine("No Product Found!!!");
            }
            else
            {
                double totalWorth = 0;
                for(int i = 0; i < count; i++)
                {
                    totalWorth = totalWorth + Price[i];
                     
                }
                Console.WriteLine($"Product Price: {totalWorth}");
            }
            
        }
    }
}
