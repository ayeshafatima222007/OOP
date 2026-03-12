using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator( 4.5,5.8);
            Console.WriteLine("Addition: " + c.Add());
            Console.WriteLine("Subtraction: " + c.Subtract());
            Console.WriteLine("Multiplication: " + c.Multiply());
            Console.WriteLine("Divide: " + c.Divide());
        }
    }
}
