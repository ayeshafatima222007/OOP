using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System_3_Tier_Model
{
    internal class StudentUI
    {
        public static StudentBL takeStudentInput()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter CGPA: ");
            float cgpa = float.Parse(Console.ReadLine());

            StudentBL s = new StudentBL(name, age, cgpa);
            return s;
        }

        public static void displayStudent(StudentBL s)
        {
            Console.WriteLine("Name: " + s.name);
            Console.WriteLine("Age: " + s.age);
            Console.WriteLine("CGPA: " + s.cgpa);
        }
    }
}
