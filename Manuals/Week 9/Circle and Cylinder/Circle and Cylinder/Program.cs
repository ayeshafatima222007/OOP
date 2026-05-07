using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_and_Cylinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
             
            Circle c1 = new Circle(2.5, "blue");            //Testing the Circle class
            Console.WriteLine("--- Circle Test ---");
            Console.WriteLine(c1.ToString());
            Console.WriteLine($"Area: {c1.getArea()}");

            Console.WriteLine("------------------------------------------");


            Cylinder cy1 = new Cylinder(2.5, 10.0, "green");           //Testing the Cylinder class (Inheritance)

            Console.WriteLine("--- Cylinder Test ---");
     
            Console.WriteLine($"Color: {cy1.getColor()}");
            Console.WriteLine($"Radius: {cy1.getRadius()}");
            Console.WriteLine($"Height: {cy1.getHeight()}");
             
            Console.WriteLine($"Volume: {cy1.getVolume()}");

            Cylinder cyDefault = new Cylinder();           //Testing Default Constructors
            Console.WriteLine("\n--- Default Cylinder ---");
            Console.WriteLine($"Default Volume: {cyDefault.getVolume()} (Radius 1.0, Height 1.0)");
             
        }
    }
}
