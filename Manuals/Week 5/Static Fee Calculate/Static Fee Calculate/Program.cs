using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Fee_Calculate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double fee = FeeCalculator.calculateFee(3);

            Console.WriteLine("Total Fee: " + fee);
        }
    }
}
