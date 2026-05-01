using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence_Constructor
{
    internal class Hostelite : Student
    {
        //----------------------Default Constructor
        /*public Hostelite() 
        {
            Console.WriteLine("Child Constructor");
        }      */


        //----------------Parametrized Constructor
        public Hostelite(string name,int age) : base (name,age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
