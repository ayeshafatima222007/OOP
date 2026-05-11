using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_and_Polymorphism
{
    internal class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle (double width,double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double CalculateArea()
        {
            return width * height;
        }

        public override string getShapeType()
        {
            return "Rectangle";
        }
    }
}
