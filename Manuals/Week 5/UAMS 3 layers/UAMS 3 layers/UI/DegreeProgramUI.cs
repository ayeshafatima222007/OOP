using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS_3_layers.BL;

namespace UAMS_3_layers.UI
{
    internal class DegreeProgramUI
    {
        public static DegreeProgramBL TakeDegreeProgramInput()
        {
            Console.Write("Enter degree title:");
            string title = Console.ReadLine();

            float duration;
            while (true)
            {
                Console.Write("Enter Degree Program Time Duration(years):");
                if (float.TryParse(Console.ReadLine(), out duration))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Enter Valid Time Duration!!");
                }
            }

            int seats;
            while (true)
            {
                Console.Write("Enter the number of seats:");
                if (int.TryParse(Console.ReadLine(), out seats))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Enter Valid Credit Hour!!");
                }
            }

            DegreeProgramBL d = new DegreeProgramBL(title, duration,seats);


            int count;
            while (true)
            {
                Console.Write("How many subjects to add: ");
                if (int.TryParse(Console.ReadLine(), out count))
                {
                    break;
                }
                else 
                {
                    Console.WriteLine("Enter valid number!");
                }
            }

            for (int i = 0; i < count; i++)
            {
                SubjectBL s = SubjectUI.TakeSubjectInput();
                d.AddSubject(s);
            }

            return d;
        }

        public static void AddSubjectToDegree(DegreeProgramBL deg)
        {
            SubjectBL s = SubjectUI.TakeSubjectInput();
            deg.AddSubject(s);
        }
    }
}
