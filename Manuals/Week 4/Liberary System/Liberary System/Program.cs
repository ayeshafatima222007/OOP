using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace self_assessment_task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title;
            List<Book> libraryList = new List<Book>();
            int pages;
            int prices;
            string author;
            bool isavailable;
            int bookMark;

           
            while (true)
            {
                int choice = 0;
                Console.WriteLine("============= LIBRARY MENU =========");
                Console.WriteLine("1. Add a Book");
                Console.WriteLine("2. Check Availibility");
                Console.WriteLine("3. Search Chapter ");
                Console.WriteLine("4. View All Books");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your Choice: ");
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    if (choice == 1)
                    {
                        Console.Write("Enter Book's title: ");
                        title = Console.ReadLine();

                        Console.Write("Enter author name: ");
                        author = Console.ReadLine();

                        Console.Write("Enter no. of pages: ");
                        pages = int.Parse(Console.ReadLine());

                        Console.Write("Enter price: ");
                        prices = int.Parse(Console.ReadLine());

                        Console.Write("Available (true/false): ");
                        isavailable = bool.Parse(Console.ReadLine());

                        Console.Write("Enter Bookmark: ");
                        bookMark = int.Parse(Console.ReadLine());


                        List<string> tempchapters = new List<string>();
                        Console.Write("How many chapters? : ");
                        int count = int.Parse(Console.ReadLine());

                        for (int i = 0; i < count; i++)
                        {
                            Console.Write($"Enter name for Chapter {i + 1}: ");
                            string chName = Console.ReadLine();
                            tempchapters.Add(chName);
                        }

                        Book newbook = new Book(title, tempchapters, pages, prices, author, isavailable, bookMark);           //object of book
                        libraryList.Add(newbook);
                    }
                    else if (choice == 2)
                    {

                        foreach (Book b in libraryList)
                        {
                            Console.WriteLine("Availability Status: {0} ", b.isBookAvailable());
                            Console.WriteLine("-----------------------------------");
                        }
                    }
                    else if (choice == 3)
                    {
                        Console.Write("Enter the title of the book you want to search: ");
                        string searchTitle = Console.ReadLine();
                        bool found = false;

                        foreach (Book b in libraryList)
                        {
                            if (b.title.ToLower() == searchTitle.ToLower()) // Search logic
                            {
                                Console.WriteLine("Enter chapter no. to search: ");
                                int chapno = int.Parse(Console.ReadLine());
                                Console.WriteLine("Chapter: {0}", b.getChapter(chapno));
                                found = true;
                                break;
                            }
                        }

                        if (!found)
                        {
                            Console.WriteLine("Book not found in library.");
                        }
                    }

                    else if (choice == 4)
                    {
                        foreach (Book b in libraryList)
                        {
                            b.displayBookInfo();
                        }
                    }

                    else if (choice == 5)
                    {
                        return;
                    }
                }

                else
                {
                    Console.WriteLine("--Invalid Choice-- ");
                }
            }
        }
    }
}
