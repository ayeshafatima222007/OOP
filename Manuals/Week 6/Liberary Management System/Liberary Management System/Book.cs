using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Liberary_Management_System
{
    internal class Book
    {
        private string bookID;
        private string bookTitle;
        private double price;

        private List<Author> authorList = new List<Author>();

        public Book(string bookID, string bookTitle, double price)
        {
            this.bookID = bookID;
            this.bookTitle = bookTitle;
            this.price = price;
      
        }

        public string getTitle()
        {
            return bookTitle;
        }
        
        public void AddAuthor(Author author)
        {
            authorList.Add(author);
        }

        public List<Author> getAuthors()        //to return authorlist for outside access
        {
            return authorList;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Book ID: {bookID}");
            Console.WriteLine($"Book Title: {bookTitle}");
            Console.WriteLine($"Book Price: {price}");

            foreach (Author author in authorList)
            {
                Console.WriteLine($"Author book: {author.getName()}");
            }

        }

        public double getPrice()
        {
            return price;
        }

    }
}
