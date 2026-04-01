using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System_3_Tier_Model
{
    internal class StudentDL
    {
        public static List<StudentBL> students = new List<StudentBL>();

        public static void addStudent(StudentBL s)
        {
            students.Add(s);
        }

        public static List<StudentBL> getStudents()
        {
            return students;
        }
    }
}
