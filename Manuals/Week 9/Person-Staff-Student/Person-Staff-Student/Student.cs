using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Staff_Student
{
    internal class Student : Person
    {
        private string program;
        private int year;
        private double fee;

        public Student(string name, string address, string program, int year, double fee) : base(name, address) // Calls Person constructor
        {
            this.program = program;
            this.year = year;
            this.fee = fee;
        }

        public override string ToString()
        {
            return $"Student\t{base.ToString()}\tprogram={program}\tyear={year}\tfee={fee}]";
        }
    }
}
