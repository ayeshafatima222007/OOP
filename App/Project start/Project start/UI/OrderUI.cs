using Project_start.BL;
using Project_start.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_start.UI
{
    internal class OrderUI
    {
        public static void AddToCart(OrderBL order)
        {
            Console.Write("Enter product ID to add to cart: ");
            string id = Console.ReadLine();

            ProductBL product = ProductDL.FindProduct(id);

            if (product == null)
            {
                Console.WriteLine("Product not found!");
                return;
            }

            if (product.getQuantity() == 0)
            {
                Console.WriteLine("Product is out of stock!");
                return;
            }
            order.getCart().AddToCart(product);
            Console.WriteLine($"{product.getName()} added to cart!");
        }

        public static void ViewCart(OrderBL order)
        {
            CartBL cart = order.getCart();

            if (cart.IsEmpty())
            {
                Console.WriteLine("Cart is empty!");
                return;
            }

            foreach (ProductBL p in cart.GetCartItems())
            {
                Console.WriteLine($"Name: {p.getName()} | Category: {p.getCategory()} | Price: {p.getPrice()}");
            }

            Console.WriteLine($"Total: {cart.GetTotal()}");
        }


        public static void RemoveFromCart(OrderBL order)
        {
            CartBL cart = order.getCart();

            if (cart.IsEmpty())
            {
                Console.WriteLine("Cart is empty!");
                return;
            }

            ProductBL removed = cart.RemoveFromCart();

            Console.WriteLine($"{removed.getName()} removed from cart!");
        }

        public static OrderBL PlaceOrder(BuyerBL buyer)
        {
            Console.Write("Enter order ID: ");
            string orderId = Console.ReadLine();

            OrderBL order = new OrderBL(orderId, buyer);
            OrderDL.AddOrder(order);
            Console.WriteLine("Order placed successfully!");
            return order;
        }

        public static void ViewOrdersByBuyer()
        {
            Console.Write("Enter buyer username: ");
            string username = Console.ReadLine();

            List<OrderBL> orders = OrderDL.FindOrdersByBuyer(username);

            if (orders.Count == 0)
            {
                Console.WriteLine("No orders found!");
                return;
            }

            foreach (OrderBL o in orders)
            {
                Console.WriteLine($"Order ID: {o.getOrderId()} | Status: {o.getStatus()} | Date: {o.getOrderDate()}");
            }
        }

        public static void ViewAllOrders()
        {
            List<OrderBL> orders = OrderDL.getAllOrders();

            if (orders.Count == 0)
            {
                Console.WriteLine("No orders found!");
                return;
            }

            foreach (OrderBL o in orders)
            {
                Console.WriteLine($"Order ID: {o.getOrderId()} | Buyer: {o.getBuyer().getUsername()} | Status: {o.getStatus()} | Date: {o.getOrderDate()}");
            }
        }
    }
}
