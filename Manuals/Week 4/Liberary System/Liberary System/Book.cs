using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace self_assessment_task_02
{
    internal class Book
    {
        public string title;
        public List<string> chapters;
     
        public int pages;
        public int price;
        public string author;
        public bool isavailable;
        public int bookMark;

         
        public Book(string title,List<string> chapters, int pages, int prices, string author, bool isavailable, int bookMark)        //parameterized constructor
        {
            this.title= title;
            this.chapters = chapters;
            this.pages = pages;
            this.price = prices;
            this.author = author;
            this.isavailable = isavailable;
            this.bookMark = bookMark;
        }
         
        public bool isBookAvailable()               //check if book is available
        {
            return isavailable;
        }

         
        public string getChapter(int chapterNumber)        //get the name of chapter  
        {
            int index=chapterNumber-1;
            if (index >= 0 && index < chapters.Count)
            {

                return chapters[index];
            }
            else
            {
                return "Chapter not found ! ";
            }
        }
        
        public int getBookMark()
        {
            Console.WriteLine("Bookmark set at page: " + bookMark);
            return bookMark;
        }
    
        public void displayBookInfo()
        {
            Console.WriteLine($"\n--- {title} ---");
            Console.WriteLine($"Author: {author} | Pages: {pages} | Price: {price}");
            Console.WriteLine($"Availability: {isavailable}");
            Console.WriteLine($"Bookmark at page: {bookMark}");
        }
    }
}
