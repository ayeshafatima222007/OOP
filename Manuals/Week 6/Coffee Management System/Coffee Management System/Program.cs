using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CoffeeShop shop = new CoffeeShop("Tesha Coffee Shop");

            shop.AddMenuItem(new MenuItem("Lemonade", "Drink", 50));
            shop.AddMenuItem(new MenuItem("Iced coffee", "Drink", 140));
            shop.AddMenuItem(new MenuItem("Cinnamon roll", "Food", 150));

            shop.AddOrder("Cinnamon roll");
            shop.AddOrder("Iced coffee");

            Console.WriteLine("Total Amount: " + shop.dueAmount());

            shop.FulfillOrder();
            shop.FulfillOrder();
            shop.FulfillOrder();
        }
    }
}
