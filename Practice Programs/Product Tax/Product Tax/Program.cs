using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Tax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> allProducts = new List<Product>();
            float tax;

            Product p = new Product();
            p.name = "Milk";
            p.category = "Grocery";
            p.price = 92;
            p.stock = 10;
            allProducts.Add(p);

            tax = p.calculateTax();


            Product p1 = new Product();
            p1.name = "Apple";
            p1.category = "Fruit";
            p1.price = 22;
            p1.stock = 10;
            allProducts.Add(p1);

            tax = p1.calculateTax();

            for (int x = 0; x < allProducts.Count; x++)
            {
                tax = allProducts[x].calculateTax();

                Console.WriteLine("{0}\t{1}\t{2}\t{3}",allProducts[x].name,allProducts[x].category,allProducts[x].price,tax);
            }


            Console.ReadKey();

        }

    }
}
