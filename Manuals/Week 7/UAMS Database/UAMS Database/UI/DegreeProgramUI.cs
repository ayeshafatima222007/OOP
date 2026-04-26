using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS_Database.BL;
using UAMS_Database.DL;

namespace UAMS_Database.UI
{
    internal class DegreeProgramUI
    {
        public static DegreeProgramBL TakeDegreeProgramInput()
        {
            Console.Write("Enter Degree Title: ");
            string title = Console.ReadLine();

            float duration;
            while (true)
            {
                Console.Write("Enter Degree Program Duration (years): ");
                if (float.TryParse(Console.ReadLine(), out duration)) break;
                Console.WriteLine("Enter Valid Duration!!");
            }

            int seats;
            while (true)
            {
                Console.Write("Enter Number of Seats: ");
                if (int.TryParse(Console.ReadLine(), out seats)) break;
                Console.WriteLine("Enter Valid Seats!!");
            }

            DegreeProgramBL d = new DegreeProgramBL(title, duration, seats);

            int count;
            while (true)
            {
                Console.Write("How many subjects to add: ");
                if (int.TryParse(Console.ReadLine(), out count)) break;
                Console.WriteLine("Enter Valid Number!!");
            }

            for (int i = 0; i < count; i++)
            {
                SubjectBL s = SubjectUI.TakeSubjectInput();
                d.AddSubject(s);

                //Save each subject to database
                SubjectDL.AddSubject(s, title);
            }

            return d;
        }

        public static void AddSubjectToDegree(DegreeProgramBL deg)
        {
            SubjectBL s = SubjectUI.TakeSubjectInput();
            deg.AddSubject(s);

            // ✅ Save subject to database
            SubjectDL.AddSubject(s, deg.GetTitle());
        }
    }
}
