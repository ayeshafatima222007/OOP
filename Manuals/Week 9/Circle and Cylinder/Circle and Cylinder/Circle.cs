using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_and_Cylinder
{
    internal class Circle
    {
        private double radius = 1.0;
        private string color = "red";

        // Constructors
        public Circle() 
        {
            //default constructor
        }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public Circle(double radius, string color)
        {
            this.radius = radius;
            this.color = color;
        }


        public double getRadius()
        {
            return radius;
        }

        public void setRadius(double radius)
        {
            this.radius = radius;
        }

        public string getColor()
        {
            return color;
        }

        public void setColor(string color)
        {
            this.color = color;
        }

        public double getArea()
        {
            return Math.PI * radius * radius;
        }

        public override string ToString()
        {
            return $"Circle[radius={radius}, color={color}]";
        }
    }
}
