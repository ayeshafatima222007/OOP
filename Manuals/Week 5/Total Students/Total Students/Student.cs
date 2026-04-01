using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Total_Students
{
    internal class Student
    {
        public string name;
        public static int studentCount = 0;

        public Student(string name)
        {
            this.name = name;
            studentCount++;
        }
    }
}
