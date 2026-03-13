using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Result
{
    internal class Program
    {
        static Student takeInput()
        {
            Student s = new Student();

            Console.Write("Enter Name: ");
            s.sname = Console.ReadLine();

            Console.Write("Enter Urdu Marks: ");
            s.urduMarks = float.Parse(Console.ReadLine());

            Console.Write("Enter English Marks: ");
            s.engMarks = float.Parse(Console.ReadLine());

            Console.Write("Enter Maths Marks: ");
            s.mathsMarks = float.Parse(Console.ReadLine());

            return s;
        }

        static void sum(Student s)
        {
            s.total = s.engMarks + s.urduMarks + s.mathsMarks;
        }

        static void output(Student s)
        {
            Console.Write(s.sname);
            Console.Write("\t");
            Console.WriteLine(s.total);
        }

        static void Main(string[] args)
        {
            List<Student> stu = new List<Student>();

            for (int x = 0; x < 3; x++)
            {
                Student temp = takeInput();
                sum(temp);
                stu.Add(temp);
            }

            foreach (Student s in stu)
            {
                output(s);
            }

            Console.Read();
        }
    }
}
