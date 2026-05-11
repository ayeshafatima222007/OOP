using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_and_Polymorphism
{
    internal class Shape
    {
        public virtual double CalculateArea()
        {
            return 0;
        }

        public virtual string getShapeType ()
        {
            return "Shape";
        }
    }
}
