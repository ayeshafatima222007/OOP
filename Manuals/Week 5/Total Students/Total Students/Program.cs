using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Total_Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Ali");
            Student s2 = new Student("Sara");
            Student s3 = new Student("Ahmed");

            Console.WriteLine("Total Students: " + Student.studentCount);
        }
    }
}
