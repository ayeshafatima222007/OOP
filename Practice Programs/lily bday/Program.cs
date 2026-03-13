using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lily_bday
{
    internal class Program
    {
        static void LillySavings(int age, double washingMachinePrice, int toyPrice)
        {
            int toysCount = 0;
            double moneySaved = 0;
            double evenMoney = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)  // Even birthday
                {
                    evenMoney += 10;
                    moneySaved += evenMoney - 1;  // Brother takes $1
                }
                else  // Odd birthday
                {
                    toysCount++;
                }
            }

            moneySaved += toysCount * toyPrice;

            Console.WriteLine("Total Saved Money: " + moneySaved);

            if (moneySaved >= washingMachinePrice)
            {
                Console.WriteLine("Yes! She can buy the washing machine.");
                Console.WriteLine("Money left: " + (moneySaved - washingMachinePrice));
            }
            else
            {
                Console.WriteLine("No! She needs more money.");
                Console.WriteLine("Money needed: " + (washingMachinePrice - moneySaved));
            }
        }
        static void Main(string[] args)
        {
            LillySavings(10, 170, 6);
        }
    }
}
