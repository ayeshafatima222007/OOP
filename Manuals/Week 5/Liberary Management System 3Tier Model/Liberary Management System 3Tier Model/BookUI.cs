using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liberary_Management_System_3Tier_Model
{
    internal class BookUI
    {
        public static BookBL takeInput()
        {
            Console.Write("Enter Book Title: ");
            string title = Console.ReadLine();

            Console.Write("Enter Author Name: ");
            string author = Console.ReadLine();

            Console.Write("Enter Price: ");
            double price = double.Parse(Console.ReadLine());

            BookBL b = new BookBL(title, author, price);

            return b;
        }

        public static void showBook(BookBL b)
        {
            Console.WriteLine("Title: " + b.title);
            Console.WriteLine("Author: " + b.author);
            Console.WriteLine("Price: " + b.price);
            Console.WriteLine("-------------------------");
        }
    }
}
