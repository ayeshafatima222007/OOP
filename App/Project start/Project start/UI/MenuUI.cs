using Project_start.BL;
using Project_start.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_start.UI
{
    internal class MenuUI
    {
        public static void Start()
        {
            while (true)
            {
                Console.WriteLine("*******************************************");
                Console.WriteLine("*      ABAYA SHOP MANAGEMENT SYSTEM       *");
                Console.WriteLine("*******************************************");
                Console.WriteLine("");
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Sign Up");
                Console.WriteLine("3. Exit");
                Console.Write("Enter choice: ");
                int choice;

                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out choice))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice!Please enter 1,2 or 3 !");
                    }
                }

                if (choice == 1)
                {
                    Login();
                }
                else if (choice == 2)
                {
                    UserUI.SignUp();
                }
                else if (choice == 3)
                {
                    break;
                }

            }
        }


        public static void Login()
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            UserBL user = UserDL.FindUser(username, password);

            if (user == null)
            {
                Console.WriteLine("Invalid username or password!");
                return;
            }

            Console.WriteLine($"Login successful! Welcome {user.getUsername()}");

            if (user.getRole() == "Admin")
            {
                AdminMenu((AdminBL)user);
            }
            else if (user.getRole() == "Seller")
            {
                SellerMenu((SellerBL)user);
            }
            else if (user.getRole() == "Buyer")
            {
                BuyerMenu((BuyerBL)user);
            }
        }


        static void AdminMenu(AdminBL admin)
        {
            while (true)
            {
                Console.WriteLine("\n=== Admin Menu ===");
                Console.WriteLine("1. View All Users");
                Console.WriteLine("2. Remove User");
                Console.WriteLine("3. View All Orders");
                Console.WriteLine("4. View All Products");
                Console.WriteLine("5. View All Payments");
                Console.WriteLine("6. Exit");
                Console.Write("Enter choice: ");

                int choice;
                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out choice))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input! Please enter a number.");
                    }
                }

                if (choice == 1)
                {
                    UserUI.ViewAllUsers();
                }
                else if (choice == 2)
                {
                    UserUI.RemoveUser();
                }
                else if (choice == 3)
                {
                    OrderUI.ViewAllOrders();
                }
                else if (choice == 4)
                {
                    ProductUI.ViewAllProducts();
                }
                else if (choice == 5)
                {
                    PaymentUI.ViewAllPayments();
                }
                else if (choice == 6)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice! Please enter choice between 1 to 6 \n");
                }
            }
        }

        static void SellerMenu(SellerBL seller)
        {
            while (true)
            {
                Console.WriteLine("\n=== Seller Menu ===");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Delete Product");
                Console.WriteLine("3. Update Product");
                Console.WriteLine("4. View All Products");
                Console.WriteLine("5. Add Discount");
                Console.WriteLine("6. View All Discounts");
                Console.WriteLine("7. Exit");
                Console.Write("Enter choice: ");

                int choice;
                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out choice))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input! Please enter a number!");
                    }
                }

                if (choice == 1)
                {
                    ProductUI.AddProduct();
                }
                else if (choice == 2)
                {
                    ProductUI.DeleteProduct();
                }
                else if (choice == 3)
                {
                    ProductUI.UpdateProduct();
                }
                else if (choice == 4)
                {
                    ProductUI.ViewAllProducts();
                }
                else if (choice == 5)
                {
                    DiscountUI.AddDiscount();
                }
                else if (choice == 6)
                {
                    DiscountUI.ViewAllDiscounts();
                }
                else if (choice == 7)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice! Please enter 1 to 7");
                }
            }
        }

        static void BuyerMenu(BuyerBL buyer)
        {
            OrderBL order = new OrderBL($"Order date and time:  {DateTime.Now:dd-MM-yyyy HH:mm:ss}", buyer);
            OrderDL.AddOrder(order);

            while (true)
            {
                Console.WriteLine("\n=== Buyer Menu ===");
                Console.WriteLine("1. Browse All Products");
                Console.WriteLine("2. Browse by Category");
                Console.WriteLine("3. Add to Cart");
                Console.WriteLine("4. View Cart");
                Console.WriteLine("5. Remove from Cart");
                Console.WriteLine("6. Apply Discount");
                Console.WriteLine("7. Checkout (Payment)");
                Console.WriteLine("8. Add Delivery");
                Console.WriteLine("9. View My Orders");
                Console.WriteLine("10. Exit");
                Console.Write("Enter choice: ");

                int choice;
                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out choice))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input! Please enter a number!");
                    }
                }

                if (choice == 1)
                {
                    ProductUI.ViewAllProducts();
                }
                else if (choice == 2)
                {
                    ProductUI.ViewByCategory();
                }
                else if (choice == 3)
                {
                    OrderUI.AddToCart(order);
                }
                else if (choice == 4)
                {
                    OrderUI.ViewCart(order);
                }
                else if (choice == 5)
                {
                    OrderUI.RemoveFromCart(order);
                }
                else if (choice == 6)
                {
                    DiscountUI.ApplyDiscount(order);
                }
                else if (choice == 7)
                {
                    PaymentUI.ProcessPayment(order);
                }
                else if (choice == 8)
                {
                    DeliveryUI.AddDelivery();
                }
                else if (choice == 9)
                {
                    OrderUI.ViewOrdersByBuyer();
                }
                else if (choice == 10)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice! Please enter choice between 1 to 10!");
                }
            }
        }

    }
}
