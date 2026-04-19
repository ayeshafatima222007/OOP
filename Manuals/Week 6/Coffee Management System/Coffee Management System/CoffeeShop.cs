using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Management_System
{
    internal class CoffeeShop
    {
        public string name;
        public List<MenuItem> menuList = new List<MenuItem>();
        public Queue<string> order = new Queue<string>();       // Queue for orders--FIFO

        public CoffeeShop(string name)
        {
            this.name = name;
        }

        public void AddMenuItem(MenuItem item)
        {
            menuList.Add(item);
        }

        // Add order
        public void AddOrder(string itemName)
        {
            foreach (MenuItem item in menuList)
            {
                if (item.Name == itemName)
                {
                    order.Enqueue(itemName);     //add order at the end so that upper orders are served first
                    Console.WriteLine("Order added!");
                    return;
                }
            }

            Console.WriteLine("This item is currently unavailable!");
       
        }

        public void FulfillOrder()
        {
            if (order.Count == 0)
            {
                Console.WriteLine("All orders have been fulfilled!");
                return;
            }
                 
            string item = order.Dequeue();               //Remove element from the front
            Console.WriteLine($"The {item} is ready!");
            return;
        }

        public int dueAmount()
        {
            int total = 0;

            foreach (string order in order)
            {
                foreach (MenuItem item in menuList)
                {
                    if (item.Name == order)
                        total += item.Price;
                }
            }

            return total;
        }

    }
}
