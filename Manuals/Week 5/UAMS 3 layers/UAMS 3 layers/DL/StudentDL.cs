using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS_3_layers.BL;     //we use BL here because we have to access BL classes

namespace UAMS_3_layers.DL     
{
    internal class StudentDL
    {
        public static List<StudentBL> studentList = new List<StudentBL>();

        public static void AddStudent(StudentBL s)
        {
            studentList.Add(s);
        }

        public static StudentBL FindByName(string name)        
        {
            foreach (StudentBL student in studentList)
            {
                if (student.Name == name && student.RegDegree != null)
                {
                    return student;
                }

            }
            return null;
        }

        public static void ViewRegisteredStudents()
        {
            foreach (StudentBL s in studentList)
            {
                if (s.RegDegree != null)
                {
                    Console.WriteLine($"{s.Name}  {s.age}");
                }
            }
        }

        public static void ViewStudentsInDegree(string name)
        {
            foreach (StudentBL s in studentList)
            {
                if (s.RegDegree != null && s.RegDegree.title == name)
                {
                    Console.WriteLine($"{s.Name}  {s.age}");
                }
            }
        }

        public static void CalculateFeeForAll()
        {
            foreach (StudentBL s in studentList)
            {
                if (s.RegDegree != null)
                {
                    Console.WriteLine($"{s.Name} has {s.CalculateFee()} fees");
                }
            }
        }
    }

}
