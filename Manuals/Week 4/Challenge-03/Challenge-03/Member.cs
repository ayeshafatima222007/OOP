using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_03
{
    internal class Member
    {
        public string memberName;
        public int memberID;              //for non-member id=0
        public int moneyInBank;
        public bool isMember;
         
        public List<string> boughtBooks = new List<string>();
        public int numOfBought;
        
        public int amountSpent;         
        public int totalSalesContrib;   
         
        public List<int> last10Prices = new List<int>();

        public const int MEMBERSHIP_FEE = 10;
        public const double MEMBER_DISCOUNT = 0.05;  


        public Member(string memberName, int memberID, int moneyInBank, bool isMember)
        {
            this.memberName = memberName;
            this.memberID = memberID;
            this.moneyInBank = moneyInBank;
            this.isMember = isMember;
            this.numOfBought = 0;
            this.amountSpent = 0;
            this.totalSalesContrib = 0;
            this.boughtBooks = new List<string>();
            this.last10Prices = new List<int>();

            if (isMember)
            {
                this.amountSpent = amountSpent+ MEMBERSHIP_FEE;
                this.totalSalesContrib = totalSalesContrib+ MEMBERSHIP_FEE;
                Console.WriteLine($"  [$10 membership fee deducted for {memberName}]");
            }
        }
 
        public int buyBook(string bookTitle, int bookPrice, int quantity)
        {
            int finalPrice = bookPrice;
            if (isMember)
            {
                finalPrice = (int)(bookPrice * 0.95);
                Console.WriteLine("Member 5% Discount Applied!");
            }
            int totalCost = finalPrice * quantity;
            if (isMember && numOfBought > 0 && numOfBought % 10 == 0)
            {
                 
                int avg = amountSpent / 10;
                Console.WriteLine($"\n11th Book Special!");
                Console.WriteLine($"Average of last 10 books: ${avg}");
                Console.WriteLine($"Discounting: ${avg} ");

                totalCost = totalCost - avg;
                if (totalCost < 0)
                {
                    totalCost= 0;
                }
                 

                amountSpent = 0;
                last10Prices.Clear();
            }

            int currentBalance = moneyInBank - totalSalesContrib;                 // Check if member has enough balance
            if (currentBalance < totalCost)
            {
                Console.WriteLine("Transaction Declined: Not enough balance!");
                return -1;
            }
          
            for (int i = 0; i < quantity; i++)                  // Purchase process
            {
                boughtBooks.Add(bookTitle);
                numOfBought++;
                last10Prices.Add(finalPrice);
                amountSpent =amountSpent+ finalPrice;
                totalSalesContrib =totalSalesContrib+ finalPrice;
            }

            Console.WriteLine($"Total Charged: ${totalCost}");
            return totalCost;
        }
  

        public void showboughtBooks()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Books Purchased: ");
            if (boughtBooks.Count == 0)
            {
                Console.WriteLine("(No purchases yet)");
                return;
            }
            foreach (string book in boughtBooks)
            {
                Console.WriteLine($"{book}");
            }
        }
        

        public void showname()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine($"Name: {memberName}");
        }
    

        public void setName(string n)
        {
            this.memberName = n;
        }
         

        public string modifyName(string n)
        {
            if (!string.IsNullOrEmpty(n))
            {
                this.memberName = n;
            }
            return memberName;
        }
        

        public void showID()
        {
            if (isMember)
            {
                Console.WriteLine($" Member ID: {memberID}");
            }
            else
            {
                Console.WriteLine($" Member ID: 0 (Non-Member)");
            }
        }
        public void setID(int id) 
        {
            memberID = id; 
        }
         

        public void showNumOfBooks()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine($"No. of Bought Books: {numOfBought}");
        }
     

        public int modifyNumOfBooks(int n)
        {
            if (n >= 0)
            {
                this.numOfBought = n;
            }
            return numOfBought;
        }
         

        public int updateNumOfBooks(int n)
        {
            numOfBought = numOfBought + n;
            return numOfBought;
        }
     

        public void showtotalSalesContrib()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine($"Amount Spent : {totalSalesContrib}");
        }
       

        public void showBankBalance()
        {
            Console.WriteLine("------------------------");
            int currentBalance = moneyInBank - totalSalesContrib;
            Console.WriteLine($"Original Bank Balance: {moneyInBank}");
            Console.WriteLine($"Total Amount Spent: {totalSalesContrib}");
            Console.WriteLine($"Current Remaining: {currentBalance}");
        }
        

        public void displayAll()
        {
            showname();
            showID();
            showNumOfBooks();
            showBankBalance();
            showboughtBooks();
            showtotalSalesContrib();
        }
     

        public bool searchByName(string name)
        {
            return memberName.ToLower().Contains(name.ToLower());
        }
    }
}
