using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS_3_layers.BL;

namespace UAMS_3_layers.DL    //we use BL here because we have to access BL classes
{
    public static class StudentDL
    {
        public static List<StudentBL> studentList = new List<StudentBL>();

        public static void AddStudent(StudentBL s)
        {
            studentList.Add(s);
        }
    }
}
