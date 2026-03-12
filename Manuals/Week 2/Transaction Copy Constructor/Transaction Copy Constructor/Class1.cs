using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transaction_Copy_Constructor
{
    internal class Transaction
    {
        public int TransactionId;
        public string ProductName;
        public double Amount;
        public DateTime DateTime;

        //parametrized constructor
        public Transaction(int id,string name,double amount,DateTime dt)
        {
            TransactionId = id;
            ProductName = name;
            Amount = amount;
            DateTime = dt;
        }

        //copy constructor
        public Transaction(Transaction t)
        {
            TransactionId = t.TransactionId;
            ProductName = t.ProductName;
            Amount = t.Amount;
            DateTime = t.DateTime;
        }

        public void Display()
        {
            Console.WriteLine("Transaction ID :  " + TransactionId);
            Console.WriteLine("Product Name: " + ProductName);
            Console.WriteLine("Amount: " + Amount);
            Console.WriteLine("Date and Time: " + DateTime);
        }
    }
}
