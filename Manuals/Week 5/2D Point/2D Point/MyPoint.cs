using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Point
{
    internal class MyPoint
    {
        public int x;
        public int y;

        public MyPoint()     //Default constructor
        {
            x = 0;
            y = 0;
        }

        public MyPoint(int x,int y)       //Parametrized constructor
        {
            this.x = x;
            this.y = y;
        }

        public int getX()
        {
            return x;
        }

        public int getY()
        {
            return y;
        }

        public void setX(int x)
        {
            this.x = x;
        }

        public void setY(int y)
        {
            this.y = y;
        }

        public void setXY(int x,int y)
        {
            this.x = x;
            this.y = y;
        }

        public double distanceWithCords(int x,int y)
        {
            return Math.Sqrt((this.x - x) * (this.x - x) + (this.y - y) * (this.y - y));
        }

        public double distanceWithObject(MyPoint P)    //P obj of MyPoint as parameter to access its x,y
        {
            return distanceWithCords(P.x,P.y);   
        }

        public double distanceFromZero()
        {
            return distanceWithCords(0,0);
        }

    }
}
