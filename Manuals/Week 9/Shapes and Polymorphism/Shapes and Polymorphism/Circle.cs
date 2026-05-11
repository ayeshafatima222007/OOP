using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_and_Polymorphism
{
    internal class Circle :Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double CalculateArea()
        {
            return 3.141 * radius * radius;
        }

        public override string getShapeType()
        {
            return "Circle";
        }
    }
}
