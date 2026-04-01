using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liberary_Management_System_3Tier_Model
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;

            do
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("-       LIBERARY MANAGEMENT SYSTEM       -");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine();

                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. View Books");
                Console.WriteLine("3. Search Book");
                Console.WriteLine("4. Exit");

                while(true)
                {
                    Console.Write("Enter your option: ");
                    if (int.TryParse(Console.ReadLine(), out option))
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Enter a valid option(1-4): ");
                    }
                }

            
                if (option == 1)
                {
                    BookBL b = BookUI.takeInput();
                    BookDL.addBook(b);
                }

                else if (option == 2)
                {
                    foreach (BookBL b in BookDL.books)
                    {
                        BookUI.showBook(b);
                    }
                }

                else if (option == 3)
                {
                    Console.Write("Enter Title: ");
                    string title = Console.ReadLine();

                    BookBL b = BookDL.searchBook(title);

                    if (b != null)
                    {
                        BookUI.showBook(b);
                    }
                    else
                    {
                        Console.WriteLine("Book Not Found");
                    }
                }

            } while (option != 4);
        }
    }
}