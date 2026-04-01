using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System_3_Tier_Model
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentBL s = StudentUI.takeStudentInput();
            StudentDL.addStudent(s);

            Console.WriteLine("\nStudent Added Successfully\n");

            foreach (StudentBL st in StudentDL.getStudents())
            {
                StudentUI.displayStudent(st);
            }

            Console.ReadKey();
        }
    }
}
