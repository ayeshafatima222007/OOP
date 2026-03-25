using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Departmental_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DepUser admin = new DepUser("Admin", "Admin123!", "Admin");           // pre-load admin as Miss Client alredy exist as admin
            DepUser.AddUserIntoList(admin);

            int choice;

            while (true)
            {
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("--            DEPARTMENTAL STORE                 --");
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("1. SignUp");
                Console.WriteLine("2. SignIn");
                Console.WriteLine("3. Exit");
                Console.WriteLine();

                while (true)
                {
                    Console.Write("Enter your choice:");
                    if (int.TryParse(Console.ReadLine(), out choice))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter a number(1-3)");
                    }
                }

                if (choice == 1)
                {
                    Console.Write("Enter Username: ");
                    string username = Console.ReadLine();

                    Console.Write("Enter Password: ");
                    string password = Console.ReadLine();

                    DepUser newUser = new DepUser(username, password, "Customer");
                    DepUser.AddUserIntoList(newUser);
                    Console.WriteLine("Sign Up Successful!");
                }

                else if (choice == 2)
                {
                    Console.Write("Enter Username: ");
                    string username = Console.ReadLine();

                    Console.Write("Enter Password: ");
                    string password = Console.ReadLine();

                    DepUser loggedUser = DepUser.AvailableUser(username, password);

                    if (loggedUser != null)
                    {
                        if (loggedUser.Role == "Admin")
                        {
                            AdminMenu();
                        }
                        else
                        {
                            CustomerMenu(loggedUser.Username);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Username or Password!");
                    }
                }

                else if (choice == 3)
                {
                    Console.WriteLine("Exiting Program!!");
                    break;
                }


            }
        }

        static void AdminMenu()
        {
            while(true)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("--              ADMIN MENU           --");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. View All Product");
                Console.WriteLine("3. Find Product with Highest Unit Price");
                Console.WriteLine("4. View Sales Tax of All Products");
                Console.WriteLine("5. Products to be Ordered");
                Console.WriteLine("6. Exit");
                Console.WriteLine();

                int choice;
                while (true)
                {
                    Console.Write("Enter your choice:");
                    if (int.TryParse(Console.ReadLine(), out choice))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter a number(1-6)");
                    }
                }


                if (choice == 1)
                {
                    Console.WriteLine("-------------- ADD PRODUCTS -------------\n");
                    Product.AddProduct();
                }

                else if (choice == 2)
                {
                    Console.WriteLine("-------------- VIEW ALL PRODUCTS -------------\n");
                    Product.ViewAllProducts();
                }

                else if (choice == 3)
                {
                    Console.WriteLine("------- FIND PRODUCT WITH HIGHEST PRICE --------\n");
                    Product.FindHighestPrice();
                }

                else if (choice == 4)
                {
                    Console.WriteLine("-------------- VIEW SALES TAX -------------\n");
                    Product.ViewSalesTax();
                }

                else if (choice == 5)
                {
                    Console.WriteLine("---------- PRODUCTS TO BE ORDERED ----------\n");
                    Product.ProductToBeOrdered();
                }

                else if (choice == 6)
                {
                    Console.WriteLine("---------- EXIT ----------\n");
                    Console.WriteLine("Exit Admin Module");
                    break;
                }
            }
        }

        static void CustomerMenu(string username)
        {
            Customer c = new Customer(username);

            while (true)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("--           CUSTOMER MENU           --");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("1. View All Product");
                Console.WriteLine("2. Buy Product");
                Console.WriteLine("3. Generate Invoice");
                Console.WriteLine("4. Exit");

                Console.WriteLine();

                int choice;
                while (true)
                {
                    Console.Write("Enter your choice:");
                    if (int.TryParse(Console.ReadLine(), out choice))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter a number(1-4)");
                    }
                }

                if (choice == 1) 
                {
                    Console.WriteLine("-------------- VIEW ALL PRODUCTS -------------\n");
                    Product.ViewAllProducts();
                }

                else if (choice == 2)
                {
                    Console.WriteLine("-------------- BUY PRODUCT -------------\n");
                    c.BuyProduct();
                }

                else if (choice == 3)
                {
                    Console.WriteLine("---------- GENERATE INVOICE ----------\n");
                    c.GenerateInvoice();
                }

                else if (choice == 4)
                {
                    Console.WriteLine("---------- EXIT ----------\n");
                    Console.WriteLine("Exit Admin Module");
                    break;
                }
            }

        }
    }
}
