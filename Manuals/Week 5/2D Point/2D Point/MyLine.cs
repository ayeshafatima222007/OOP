using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Point
{
    internal class MyLine
    {
        public MyPoint begin;
        public MyPoint end;

        public MyLine(MyPoint begin,MyPoint end) 
        {
            this.begin = begin;
            this.end = end;
        }

        public MyPoint getBegin()
        {
            return begin;
        }

        public void setBegin(MyPoint begin)
        {
            this.begin = begin;
        }

        public MyPoint getEnd()
        {
            return end;
        }

        public void setEnd(MyPoint end)
        {
            this.end = end;
        }

        public double getLength()
        {
            return begin.distanceWithObject(end);

        }

        public double getGradient()
        {
            return (double) (end.getY() - begin.getY()) / (end.getX() - begin.getX());      // Gradient formula= m = (y2 - y1) / (x2 - x1)
        }

    }
}
