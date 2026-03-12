using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;

            Student C = new Student();

            do
            {

                Console.WriteLine("\t\t STUDENT MANAGEMENT SYSTEM");
                Console.WriteLine("1.Add Student");
                Console.WriteLine("2.Show Students");
                Console.WriteLine("3.Top Students");
                Console.WriteLine("4.Exit\n");
                Console.WriteLine("Enter Your Choice");

                choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    C.AddStudent();
                }
                if (choice == 2)
                {
                    C.ShowStudent();
                }
                if (choice == 3)
                {
                    C.TopStudents();
                }

            }
            while (choice != 4);


        }
    }
}
