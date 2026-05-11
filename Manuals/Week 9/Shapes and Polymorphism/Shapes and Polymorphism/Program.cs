using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_and_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //single common list for all shapes

            List<Shape> shapeList = new List<Shape>();

            double width;
            while(true)
            {
                Console.WriteLine("Enter Width: ");

                if (double.TryParse(Console.ReadLine(),out width))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Enter valid value");
                }
            }

            double height;
            while (true)
            {
                Console.WriteLine("Enter height: ");

                if (double.TryParse(Console.ReadLine(), out height))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Enter valid value");
                }
            }

            Rectangle rect = new Rectangle(width , height);
            shapeList.Add(rect);


            double side;
            while (true)
            {
                Console.WriteLine("Enter side of square: ");

                if (double.TryParse(Console.ReadLine(), out side))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Enter valid value");
                }
            }

            Square sq = new Square(side);
            shapeList.Add(sq);



            double radius;
            while (true)
            {
                Console.WriteLine("Enter radius of circle: ");

                if (double.TryParse(Console.ReadLine(), out radius))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Enter valid value");
                }
            }

            Circle c = new Circle(radius);
            shapeList.Add(c);


            Console.WriteLine("-----Shape output-----");

            for (int i = 0 ; i<shapeList.Count;i++)
            {
                Console.WriteLine($"{i + 1}");
                Console.WriteLine($"The shape is {shapeList[i].getShapeType()} and the shape area is {shapeList[i].CalculateArea()}");

            }
        }
    }
}
