using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using UAMS_3_layers.BL;
using UAMS_3_layers.DL;

namespace UAMS_3_layers.UI
{
    internal class StudentUI
    {
        public static StudentBL takeInputForStudent()       
        {
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Student Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter FSC Marks: ");
            float FSC = float.Parse(Console.ReadLine());

            Console.Write("Enter ECAT Marks: ");
            float ECAT = float.Parse(Console.ReadLine());

            StudentBL stu = new StudentBL(name, age, FSC, ECAT);

            Console.WriteLine("Available Degree Programs:");
            foreach (DegreeProgramBL d in DegreeProgramDL.programList)
            {
                Console.WriteLine(d.title);
                Console.WriteLine(d.duration);
            }

            Console.Write("How many preferences: ");
            int pref = int.Parse(Console.ReadLine());

            for (int i = 0; i < pref; i++)
            {
                Console.Write($"Enter Preference { i + 1} : ");
                string chooseDegree = Console.ReadLine();

                foreach (DegreeProgramBL d in DegreeProgramDL.programList)
                {
                    if (d.title == chooseDegree)
                    {
                        stu.prefrences.Add(d);
                    }
                }
            }

            return stu;
        }

        public static void PrintMeritList(List<StudentBL> sortedList)
        {
            foreach (StudentBL s in sortedList)
            {
                if (s.RegDegree != null)
                {
                    Console.WriteLine($"{s.Name} got admission in {s.RegDegree.title}");
                }
                else
                {
                    Console.WriteLine($"{s.Name} did not get admission");
                }
            }
        }
        public static void RegisterSubjects(StudentBL s)
        {
            if (s != null)   //Student regeistered sub for degree
            {
                Console.WriteLine("SubCode\tType\tCredit Hours\tFees");
                foreach (SubjectBL sub in s.RegDegree.subjects)
                {
                    Console.WriteLine($"{sub.SubjCode}\t{sub.SubjType}\t{sub.CRH}\t{sub.SubjFee}");
                }

                Console.Write("Enter Subject Code to Register: ");
                string code = Console.ReadLine();

                SubjectBL selectedSubject = SubjectDL.FindByCode(s.RegDegree.subjects, code);     //checking if the entered subj code matches the available subject code

                if (selectedSubject != null)
                {

                    bool success = s.StdRegSubj(selectedSubject);

                    if (success)
                    {
                        Console.WriteLine("Subject Registered Successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Registration Failed. 9 Credit Hour limit exceeded.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Subject Code!");
                }
            }
        }


    }
}
