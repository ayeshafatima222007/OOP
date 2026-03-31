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
            while (true)
            {
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
                    if (int.TryParse(Console.ReadLine(), out option))
                    {
                        Console.Write("Enter option: ");
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
                    int Ey = int.Parse(Console.ReadLine());
 


                }
                else if (option == 2)
                {
                    Console.WriteLine("---Update the begin point---");
                }

                else if (option == 3)
                {
                    Console.WriteLine("---Update the end point---");
                }

                else if (option == 4)
                {
                    Console.WriteLine("---Show the begin point---");
                }

                else if (option == 5)
                {
                    Console.WriteLine("---Show the end point---");
                }

                else if (option == 6)
                {
                    Console.WriteLine("---Get the Length of the line---");
                }

                else if (option == 7)
                {
                    Console.WriteLine("---Get the Gradient of the Line---");
                }

                else if (option == 8)
                {
                    Console.WriteLine("---Distance of begin point from origin---");
                }

                else if (option == 9)
                {
                    Console.WriteLine("---Distance of end point from origin---");
                }

                else if (option == 10)
                {
                    Console.WriteLine("---Exit---");
                    Console.WriteLine("");
                    Console.WriteLine("Enter any key to exit");
                    Console.ReadKey();
                }
            }
            
        }
    }
}
