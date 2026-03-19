using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_03
{
    internal class Book
    {
        public string title;
        public string[] authors = new string[4];

        public int authorCount;               //track the no. of authors added
        public string publisher;
        public string isbn;
        public int price;
        public int stock;
        public int yearOfPublication;  

         
        public Book(string title, string[] authors, int authorCount, string publisher, string isbn, int price, int stock, int yearOfPublication)        // Parameterized constructor
        {
            this.title = title;
            this.authors = authors;
            this.authorCount = authorCount;
            this.publisher = publisher;
            this.isbn = isbn;
            this.price = price;
            this.stock = stock;
            this.yearOfPublication = yearOfPublication;
        }
         

        public void showTitle()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine($" Title : {title}");
        }
         

        public void setTitle(string t)
        {
            title = t; 
        }
         

        public string getTitle()
        {
            return title;
        }
        

        public bool searchTitle(string t)
        {
            if (title.ToLower() == t.ToLower())
            {
                return true;
            }
            return false;
        }
         

        public void showStock()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine($" Stock : {stock}");
        }
        

        public void setStock(int s)
        {
            stock = s;
        }
         

        public int getStock()
        {
            return stock;
        }
         

        public int updateStock(int s)
        {
            stock = stock + s;
            return stock;
        }
         

        public void showpublisher()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine($" Publisher : {publisher}");

        }
         

        public void setPublisher(string p)
        {
            publisher = p;
        }
         

        public string getPublisher()
        {
            return publisher;
        }
         

        public void showISBN()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine($" ISBN : {isbn}");

        }
        

        public bool searchISBN(string i)
        {
            if (isbn.ToLower() == i.ToLower())
            {
                return true;
            }
            return false;
        }
         

        public void setISBN(string i)
        {
            isbn = i;
        }
        

        public void showPrice()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine($" Price : {price}");

        }
         

        public void setPrice(int p)
        {
            price = p;
        }
     

        public int getPrice()
        {
            return price;
        }
         

        public void showYear()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine($" Year Published   : {yearOfPublication}");
        }
       

        public void showAuthor()
        {
            Console.WriteLine("------------------------");
            for (int i = 0; i < authorCount; i++)
            {
                Console.WriteLine($"Author {i + 1} is: {authors[i]}");
            }
        }
         

        public void addAuthor(String name)
        {
            if (authorCount < 4)
            {
                authors[authorCount] = name;
                authorCount++;
                Console.WriteLine("Author added !");
            }
            else
            {
                Console.WriteLine("Error: Maximum of 4 authors reached!");
            }
        }
         

        public int getAuthorCount()
        {
            return authorCount;
        }
         

        public void displayAll()
        {
            showTitle();
            showAuthor();
            showpublisher();
            showYear();
            showISBN();
            showPrice();
            showStock();
        }
    }
}
