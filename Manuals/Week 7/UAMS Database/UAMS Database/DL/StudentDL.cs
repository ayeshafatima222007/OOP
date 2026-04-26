using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS_Database.DL
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
                if (student.GetName() == name && student.GetRegDegree() != null)
                    return student;
            return null;
        }

        public static void ViewRegisteredStudents()
        {
            foreach (StudentBL s in studentList)
                if (s.GetRegDegree() != null)
                    Console.WriteLine($"{s.GetName()}  {s.GetAge()}");
        }

        public static void ViewStudentsInDegree(string name)
        {
            foreach (StudentBL s in studentList)
                if (s.GetRegDegree() != null && s.GetRegDegree().GetTitle() == name)
                    Console.WriteLine($"{s.GetName()}  {s.GetAge()}");
        }

        public static void CalculateFeeForAll()
        {
            foreach (StudentBL s in studentList)
                if (s.GetRegDegree() != null)
                    Console.WriteLine($"{s.GetName()} has {s.CalculateFee()} fees");
        }
    }
}
