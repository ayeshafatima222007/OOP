using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_and_Cylinder
{
    internal class Cylinder : Circle
    {
        private double height = 1.0;
        public Cylinder() : base() 
        {
            //base handles by parent class
        }

        public Cylinder(double radius) : base(radius) 
        {
            //base handles by parent class
        }

        public Cylinder(double radius, double height) : base(radius)
        {
            this.height = height;
        }

        public Cylinder(double radius, double height, string color) : base(radius, color)
        {
            this.height = height;
        }

        public double getHeight() => height;
        public void SetHeight(double height)
        {
            this.height = height;
        }

        public double getVolume()
        {
            // Reuses the GetArea() method from the Circle class
            return getArea() * height;
        }
    }
}
