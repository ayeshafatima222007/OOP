using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS_3_layers.UI
{
    public static class ConsoleUtility
    {
        public static void Header()
        {
            Console.WriteLine("************************************************************");
            Console.WriteLine("                   UAMS  Using 3 Tier Model                 ");
            Console.WriteLine("************************************************************");
        }

        public static int ShowMenu()
        {
            Header();
            Console.WriteLine("1.Add Student");
            Console.WriteLine("2.Add Degree Program");
            Console.WriteLine("3.Add Subjects to Degree Program");
            Console.WriteLine("4.Generate Merit List");
            Console.WriteLine("5.View Registered Students");
            Console.WriteLine("6.View Students of a Specific Program");
            Console.WriteLine("7.Register Subjects for a Specific Students");
            Console.WriteLine("8.Calculate Fee for all Registered Students");
            Console.WriteLine("9.Exit");
            Console.WriteLine("");
             

            int choice;

            while(true)
            {
                Console.Write("Enter Option: ");
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Enter Valid Option!!");
                    Console.WriteLine("");
                }
            }

            return choice;
        }

        public static void Pause()
        {
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
