using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence_Constructor
{
    internal class Student
    {
        //----------------------Default Constructor
        /*public Student()
        {
            Console.WriteLine("Parent Constructor");
        }         */




        //----------------Parametrized Constructor
        public string name;
        public int age;
        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }


    }
}
