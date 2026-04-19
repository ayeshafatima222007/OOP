using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liberary_Management_System
{
    internal class Author
    {
        private string name;
        private string ID;
        private List<Book> bookList = new List<Book>();

        public Author(string name, string ID)
        {
            this.name = name;
            this.ID = ID;

        }

        public string getName()
        {
            return name;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Author Name: {name}");
            Console.WriteLine($"Author ID: {ID}");

            foreach (Book book in bookList)
            {
                Console.WriteLine($"Author book: {book.getTitle()}");
            }

        }

        public void AddBook(Book book)
        {
            bookList.Add(book);
        }

        public List<Book> getBook()
        {
            return bookList;
        }

    }
}
