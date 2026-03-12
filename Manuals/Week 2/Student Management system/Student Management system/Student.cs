using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_system
{
    internal class Student
    {
        /*Create menu driven program: 
         • Add Student 
         • Show Students 
         • Calculate Aggregate 
         • Top Students
         Use class and functions.*/

        int count = 0;       //variables for adding student data
        string name;
        string[] Name = new string [50];

        string StdID;
        string[] ID = new string[50];

        string StdCourse;
        string[] course = new string[50];

        double MetricMarks;  
        double FScMarks;
        double ECATMarks;

        double aggregate;       //aggregate is being calculate in adding student functionality so that we can find top student
        double[] Agg = new double[50];

        public void AddStudent()
        {
            count++;
            Console.Write("Enter the student ID: ");
            StdID = Console.ReadLine();

            Console.Write("Enter the student name:");
            name = Console.ReadLine();

            Console.Write("Enter the student course: ");
            StdCourse = Console.ReadLine();

            Console.Write("Enter the student Metric Marks: ");
            MetricMarks = double.Parse(Console.ReadLine());

            Console.Write("Enter the student FSc Marks: ");
            FScMarks = double.Parse(Console.ReadLine());

            Console.Write("Enter the student ECAT Marks: ");
            ECATMarks = double.Parse(Console.ReadLine());

            ID[count] = StdID;
            Name[count] = name;
            course[count] = StdCourse;

            aggregate = ((MetricMarks*0.1)+(FScMarks*0.2)+(ECATMarks*0.7));
            Agg[count] = aggregate;

            Console.WriteLine($"Your calculated aggregate is: {aggregate}\n\n");

        }

        public void ShowStudent()
        {
            if (count == 0)
            {
                Console.WriteLine("No student data found...");
            }
            else
            {
                for (int i = 1; i <= count; i++)
                {

                    Console.WriteLine($"Student ID: {ID[i]}");
                    Console.WriteLine($"Student Name: {Name[i]}");
                    Console.WriteLine($"Student course: {course[i]}");
                    Console.WriteLine($"Aggregate: {Agg[i]}");

                }
            }
        }
        public void TopStudents()
        {
            if (count == 0)
            {
                Console.WriteLine("No student data found...");
            }

            else 
            {
                double max = Agg[1];

                for (int i = 2; i <= count; i++)
                {
                    if (Agg[i] > max)
                    {
                        max =  Agg [i];
                    }
                }

                Console.WriteLine("Top Students:");

                for (int i = 1; i <= count; i++)
                {
                    if ( Agg[i] == max)
                    {
                        Console.WriteLine($"Student ID: {ID[i]}");
                        Console.WriteLine($"Name: {Name[i]}");
                        Console.WriteLine($"Student course: {course[i]}");
                        Console.WriteLine($"Aggregate: {Agg[i]}");
                    }
                }
            }
            


        }





    }
}
