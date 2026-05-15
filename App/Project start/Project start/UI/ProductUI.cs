using Project_start.BL;
using Project_start.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_start.UI
{
    internal class ProductUI
    {
        public static void AddProduct()        //1.Add
        {
            Console.Write("Enter product ID: ");
            string id = Console.ReadLine();

            Console.WriteLine("Enter category (Casual-Formal-Embroidered-Sports): ");
            string category = Console.ReadLine();

            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            Console.Write("Enter color: ");
            string color = Console.ReadLine();

            Console.WriteLine("Enter size (S/M/L  or  s/m/l): ");
            string size = Console.ReadLine();

            Console.Write("Enter price: ");
            double price = double.Parse(Console.ReadLine());

            Console.Write("Enter quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            ProductBL product = new ProductBL(id, category, name, color, size, price, quantity);
            ProductDL.AddProduct(product);
            Console.WriteLine("Product added successfully!");
        }

        public static void ViewAllProducts()        //2.View
        {
            List<ProductBL> products = ProductDL.getAllProducts();
            if (products.Count == 0)
            {
                Console.WriteLine("No products found!");
                return;
            }
            foreach (ProductBL p in products)
            {
                Console.WriteLine($"ID: {p.getProductId()} | Name: {p.getName()} | Category: {p.getCategory()} | Color: {p.getColor()} | Size: {p.getSize()} | Price: {p.getPrice()} | Qty: {p.getQuantity()}");
            }
        }

        public static void ViewByCategory()       //3.view category wise
        {
            Console.WriteLine("Enter category (Casual/Formal/Embroidered/Sports): ");
            string category = Console.ReadLine();

            List<ProductBL> products = ProductDL.FindByCategory(category);
            if (products.Count == 0)
            {
                Console.WriteLine("No products found in this category!");
                return;
            }
            foreach (ProductBL p in products)
            {
                Console.WriteLine($"ID: {p.getProductId()} | Name: {p.getName()} | Color: {p.getColor()} | Size: {p.getSize()} | Price: {p.getPrice()} | Qty: {p.getQuantity()}");
            }
        }

        public static void UpdateProduct()           //4.Update
        {
            Console.Write("Enter product ID to update: ");
            string id = Console.ReadLine();

            ProductBL existing = ProductDL.FindProduct(id);
            if (existing == null)
            {
                Console.WriteLine("Product not found!");
                return;
            }

            Console.WriteLine("Enter new category (Casual/Formal/Embroidered/Sports): ");
            string category = Console.ReadLine();

            Console.Write("Enter new name: ");
            string name = Console.ReadLine();

            Console.Write("Enter new color: ");
            string color = Console.ReadLine();

            Console.WriteLine("Enter new size (S/M/L): ");
            string size = Console.ReadLine();

            Console.Write("Enter new price: ");
            double price = double.Parse(Console.ReadLine());

            Console.Write("Enter new quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            ProductBL updated = new ProductBL(id, category, name, color, size, price, quantity);
            ProductDL.UpdateProduct(id, updated);
            Console.WriteLine("Product updated successfully!");
        }

        public static void DeleteProduct()          //5.Delete
        {
            Console.Write("Enter product ID to delete: ");
            string id = Console.ReadLine();

            ProductBL product = ProductDL.FindProduct(id);
            if (product == null)
            {
                Console.WriteLine("Product not found!");
                return;
            }
            ProductDL.DelProduct(id);
            Console.WriteLine("Product deleted successfully!");
        }
    }
}
