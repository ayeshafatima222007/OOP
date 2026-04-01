using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System_3_Tier_Model
{
    internal class StudentBL
    {
        public string name;
        public int age;
        public float cgpa;

        public StudentBL(string name, int age, float cgpa)
        {
            this.name = name;
            this.age = age;
            this.cgpa = cgpa;
        }
    }
}
