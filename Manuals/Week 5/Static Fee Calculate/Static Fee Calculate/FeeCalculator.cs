using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Fee_Calculate
{
    internal class FeeCalculator
    {
        public static double calculateFee(double creditHours)
        {
            return creditHours * 5000;
        }
    }
}
