using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Liberary_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************************************");
            Console.WriteLine("*       LIBERARY MANAGEMENT SYSTEM     *");
            Console.WriteLine("****************************************\n");

            Console.Write("Enter Name of Author: ");
            string name = Console.ReadLine();

            Console.Write("Enter Author ID: ");
            string AuthorId = Console.ReadLine();

            Author author = new Author(name,AuthorId);


            Console.Write("Enter Name of Book: ");
            string title = Console.ReadLine();

            Console.Write("Enter BookID: ");
            string bookId = Console.ReadLine();

            double price;
            while (true)
            {
                Console.WriteLine("Enter price of Book: ");
                if (double.TryParse(Console.ReadLine(), out price))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Enter a valid integer for price: ");
                }
            }

            Book book = new Book(bookId, title, price);

            book.AddAuthor(author);   //Assign author to book 

            author.AddBook(book);      //Assign book to author 

            book.DisplayInfo();      //Display book information 

        }
    }
}
