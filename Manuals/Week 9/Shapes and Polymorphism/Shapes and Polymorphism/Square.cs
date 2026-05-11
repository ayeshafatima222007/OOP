using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_and_Polymorphism
{
    internal class Square : Shape
    {
        private double side;

        public Square(double side)
        {
            this.side = side;
        }

        public override double CalculateArea()
        {
            return side * side;
        }

        public override string getShapeType()
        {
            return "Square";
        }
    }
}
