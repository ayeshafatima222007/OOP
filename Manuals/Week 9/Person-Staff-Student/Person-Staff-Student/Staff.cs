using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Staff_Student
{
    internal class Staff : Person
    {
        private string school;
        private double pay;

        public Staff(string name, string address, string school, double pay) : base(name, address)
        {
            this.school = school;
            this.pay = pay;
        }

        public override string ToString()
        {
            return $"Staff\t{base.ToString()}\tschool={school}\tpay={pay}]";
        }
    }
}
