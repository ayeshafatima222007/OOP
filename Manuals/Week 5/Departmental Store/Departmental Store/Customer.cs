using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Departmental_Store
{
    internal class Customer
    {
        public string CustomerName;
        public List<Product> CartProduct;
        public List<int> CartQty;

        public Customer(string CustomerName)
        {
            this.CustomerName = CustomerName;

            this.CartProduct = new List<Product>();
            this.CartQty = new List<int>();
        }

        public void BuyProduct()
        {
            if (Product.ProductList.Count == 0)
            {
                Console.WriteLine("No Product Found");
            }
            else
            {
                Product.ViewAllProducts();

                Console.Write("Enter the name of the product:");     //asking the name of product from customer
                string name = Console.ReadLine();

                int Qty;      //asking the qunatity of product from customer

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


                bool found = false;

                foreach (Product p in Product.ProductList) 
                {
                    if (p.ProdName== name && p.ProdQty >= Qty)
                    {
                        found = true;
                        Console.WriteLine("Product is available");
                        CartProduct.Add(p);   // add product to cart
                        CartQty.Add(Qty);     // add quantity to cart

                        p.ProdQty -= Qty;

                        Console.WriteLine("Added to cart!!");
                        break;

                    }
                    else if (p.ProdName == name && p.ProdQty < Qty)
                    {
                        found = true;
                        Console.WriteLine("Not enough stock!");
                        break;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("Product not found!!");
                }
            }

        }
        
        public void GenerateInvoice()
        {
            if (CartProduct.Count == 0)
            {
                Console.WriteLine("Cart is empty");
            }
            else
            {
                Console.WriteLine("------------INVOICE-------------");

                double total = 0;
                
                for (int i=0; i<CartProduct.Count;i++)
                {
                    int Qty = CartQty[i];                //get qty from cart
                    Product p = CartProduct[i];          //get product from cart
                    double tax = 0;

                    if (p.Category == "Grocery")
                        tax = p.ProdPrice * 0.10;
                    else if (p.Category == "Fruit")
                        tax = p.ProdPrice * 0.05;
                    else
                        tax = p.ProdPrice * 0.15;

                    double taxedPrice = p.ProdPrice + tax;        // price after tax
                    double itemTotal = taxedPrice * Qty;           // total for this item
                    total += itemTotal;                            // add to grand total

                    // print item details
                    Console.WriteLine($"Product: {p.ProdName}");
                    Console.WriteLine($"Quantity: {Qty}");
                    Console.WriteLine($"Price: {p.ProdPrice}");
                    Console.WriteLine($"Tax: {tax}");
                    Console.WriteLine($"Item Total: {itemTotal}");
                    Console.WriteLine("---------------------------");
                }
                Console.WriteLine($"Grand Total: {total}");
            }
        }
    }
}
