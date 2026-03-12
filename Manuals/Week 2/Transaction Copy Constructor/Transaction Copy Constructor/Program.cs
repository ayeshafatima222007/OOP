using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transaction_Copy_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //making first object
            Transaction t1 = new Transaction(21, "Shoes", 2000, DateTime.Now);

            //copy constructor
            Transaction t2 = new Transaction(t1);

            Console.WriteLine(" Original Transaction");
            t1.Display();

            Console.WriteLine();

            Console.WriteLine("Copied Transaction");
            t2.Display();
        }
    }
}
