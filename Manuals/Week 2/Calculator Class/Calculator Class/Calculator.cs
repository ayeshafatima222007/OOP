using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Class
{
    internal class Calculator
    {
        double num1;
        double num2;
        public Calculator(double x, double y)
        {
            num1 = x;
            num2 = y;
        }

        public double Add()
        {
            return num1 + num2;
        }
        public double Subtract()
        {
            return num1 - num2;
        }
        public double Multiply()
        {
            return num1 * num2;
        }
        public double Divide()
        {
            return num1 / num2;
        }

    }
}
