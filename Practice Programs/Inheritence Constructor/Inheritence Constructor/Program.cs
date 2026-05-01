using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //------------------Default Constructor concept---------------------

            //Hostelite host = new Hostelite();

            //Student student = new Student();




            //------------------Parametrized Constructor concept---------------------
            //for one variable
            /*string name;
            Hostelite host = new Hostelite("Ayesha");
            Console.WriteLine(host.name);*/


            // for two or more variables
            string name;
            Hostelite host = new Hostelite("Ayesha",19);
            Console.WriteLine(host.name);
            Console.WriteLine(host.age);


        }
    }
}
