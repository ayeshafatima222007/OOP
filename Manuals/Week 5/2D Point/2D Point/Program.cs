using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyLine line = null;

            while (true)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("-          2D Point Model       -");
                Console.WriteLine("---------------------------------");

                Console.WriteLine("1. Make a Line");
                Console.WriteLine("2. Update the begin point");
                Console.WriteLine("3. Update the end point");
                Console.WriteLine("4. Show the begin point");
                Console.WriteLine("5. Show the end point");
                Console.WriteLine("6. Get the Length of the line");
                Console.WriteLine("7. Get the Gradient of the Line");
                Console.WriteLine("8. Distance of begin point from origin");
                Console.WriteLine("9. Distance of end point from origin");
                Console.WriteLine("10. Exit");
                Console.WriteLine("");

                int option;
                while (true)
                {
                    Console.Write("Enter option: ");
                    if (int.TryParse(Console.ReadLine(), out option))
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Enter Valid option(1-10): ");
                    }
                }

                Console.WriteLine("");
                Console.WriteLine("");

                if (option == 1 )
                {
                    Console.WriteLine("---Make a Line---");

                    Console.Write("Enter x of line begin");       //coordiantes of line begin
                    int bx = int.Parse(Console.ReadLine());

                    Console.Write("Enter y of line begin");
                    int by = int.Parse(Console.ReadLine());

                    Console.Write("Enter x of line end");       //coordiantes of line end
                    int ex = int.Parse(Console.ReadLine());

                    Console.Write("Enter y of line end");     
                    int ey = int.Parse(Console.ReadLine());
 
                    MyPoint xy = new MyPoint(bx, by);         //assigning points
                    MyPoint XY = new MyPoint(ex, ey);

                    line = new MyLine(xy,XY);               //assigning points to line

                    Console.WriteLine("--Line created!--");
                }
                else if (option == 2)
                {
                    Console.WriteLine("---Update the begin point---");

                    if (line == null)
                    {
                        Console.WriteLine("Create a line first");
                    }
                    else 
                    {
                        Console.Write("Enter new value of x of line begin");       //coordiantes of line begin
                        int Newbx = int.Parse(Console.ReadLine());

                        Console.Write("Enter new valueof y of line begin");
                        int Newby = int.Parse(Console.ReadLine());

                        MyPoint newBegin = new MyPoint(Newbx,Newby);
                        line.setBegin(newBegin);
                    }
                }

                else if (option == 3)
                {
                    Console.WriteLine("---Update the end point---");

                    if (line == null)
                    {
                        Console.WriteLine("Create a line first");
                    }
                    else
                    {
                        Console.Write("Enter new value of x of line end");       //coordiantes of line begin
                        int Newex = int.Parse(Console.ReadLine());

                        Console.Write("Enter new valueof y of line end");
                        int Newey= int.Parse(Console.ReadLine());

                        MyPoint newEnd = new MyPoint(Newex, Newey);
                        line.setEnd(newEnd);
                    }
                }

                else if (option == 4)
                {
                    Console.WriteLine("---Show the begin point---");

                    if (line == null)
                    {
                        Console.WriteLine("Create a line first");
                    }
                    else
                    {
                        Console.WriteLine($"Begin point: {line.getBegin().getX()} ,{line.getBegin().getY()}");
                    }
                     
                }

                else if (option == 5)
                {
                    Console.WriteLine("---Show the end point---");
                    if (line == null)
                    {
                        Console.WriteLine("Create a line first");
                    }
                    else
                    {
                        Console.WriteLine($"End point: {line.getEnd().getX()} ,{line.getEnd().getY()}");
                    }

                }

                else if (option == 6)
                {
                    Console.WriteLine("---Get the Length of the line---");
                    if (line == null)
                    {
                        Console.WriteLine("Create a line first");
                    }
                    else
                    {
                        Console.WriteLine("Length of line: " + line.getLength());
                    }
                }

                else if (option == 7)
                {
                    Console.WriteLine("---Get the Gradient of the Line---");

                    if (line == null)
                    {
                        Console.WriteLine("Create a line first");
                    }
                    else
                    {
                        Console.WriteLine("Gradient of line: " + line.getGradient());
                    }
                }

                else if (option == 8)
                {
                    Console.WriteLine("---Distance of begin point from origin---");
                    if (line == null)
                    {
                        Console.WriteLine("Create a line first");
                    }
                    else
                    {
                        Console.WriteLine($"Distance from origin: {line.getBegin().distanceFromZero()}");    //Call distanceFromZero() on the begin point object
                    }
                }

                else if (option == 9)
                {
                    Console.WriteLine("---Distance of end point from origin---");

                    if (line == null)
                    {
                        Console.WriteLine("Create a line first");
                    }
                    else
                    {
                        Console.WriteLine($"Distance from origin: {line.getEnd().distanceFromZero()}");          //Call distanceFromZero() on the end point object
                    }
                }

                else if (option == 10)
                {
                    Console.WriteLine("---Exit---");
                    Console.WriteLine("");
                    Console.WriteLine("Enter any key to exit");
                    Console.ReadKey();
                    break;
                }
            }
            
        }
    }
}
