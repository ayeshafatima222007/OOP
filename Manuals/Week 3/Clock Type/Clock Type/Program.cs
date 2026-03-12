using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clockType clock1 = new clockType(10, 30, 20);
            clockType clock2 = new clockType(14, 10, 5);

            Console.Write("Clock 1 time: ");
            clock1.DisplayTime();

            Console.Write("Clock 2 time: ");
            clock2.DisplayTime();

            Console.WriteLine("Elapsed Time Clock1 (sec): " + clock1.ElapsedTime());

            Console.WriteLine("Remaining Time Clock1 (sec): " + clock1.RemainingTime());

            Console.WriteLine("Difference Between Clocks (sec): " + clock1.Difference(clock2));
        }
    }
}
