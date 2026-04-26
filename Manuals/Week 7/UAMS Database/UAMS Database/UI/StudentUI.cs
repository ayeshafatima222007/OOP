using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS_Database.BL;
using UAMS_Database.DL;

namespace UAMS_Database.UI
{
    internal class StudentUI
    {
        public static StudentBL TakeInputForStudent()
        {
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            int age;
            while (true)
            {
                Console.Write("Enter Student Age: ");
                if (int.TryParse(Console.ReadLine(), out age))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Enter Valid Age!!");
                }
            }

            float fsc;
            while (true)
            {
                Console.Write("Enter FSC Marks: ");
                if (float.TryParse(Console.ReadLine(), out fsc))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Enter Valid Marks!!");
                }
            }

            float ecat;
            while (true)
            {
                Console.Write("Enter ECAT Marks: ");
                if (float.TryParse(Console.ReadLine(), out ecat))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Enter Valid Marks!!");
                }
            }

            StudentBL stu = new StudentBL(name, age, fsc, ecat);

            Console.WriteLine("Available Degree Programs:");
            foreach (DegreeProgramBL d in DegreeProgramDL.programList)
            {
                Console.WriteLine($"Title: {d.GetTitle()}  Duration: {d.GetDuration()} years");
            }

            int pref;
            while (true)
            {
                Console.Write("How many preferences: ");
                if (int.TryParse(Console.ReadLine(), out pref))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Enter Valid Number!!");
                }
            }

            for (int i = 0; i < pref; i++)
            {
                Console.Write($"Enter Preference {i + 1}: ");
                string chooseDegree = Console.ReadLine();

                foreach (DegreeProgramBL d in DegreeProgramDL.programList)
                {
                    if (d.GetTitle() == chooseDegree)
                    {
                        stu.GetPreferences().Add(d);
                    }
                }
            }

            return stu;
        }

        public static void PrintMeritList(List<StudentBL> sortedList)
        {
            Console.WriteLine("\n========== Merit List ==========");
            foreach (StudentBL s in sortedList)
            {
                if (s.GetRegDegree() != null)
                {
                    Console.WriteLine($"{s.GetName()} got admission in {s.GetRegDegree().GetTitle()}");
                }
                else
                {
                    Console.WriteLine($"{s.GetName()} did not get admission");
                }
            }
        }

        public static void RegisterSubjects(StudentBL s)
        {
            if (s != null)
            {
                Console.WriteLine("\nSubCode\tType\tCredit Hours\tFees");
                foreach (SubjectBL sub in s.GetRegDegree().GetSubjects())
                {
                    Console.WriteLine($"{sub.GetSubjCode()}\t{sub.GetSubjType()}\t{sub.GetCRH()}\t{sub.GetSubjFee()}");
                }

                Console.Write("Enter Subject Code to Register: ");
                string code = Console.ReadLine();

                SubjectBL selectedSubject = SubjectDL.FindByCode(s.GetRegDegree().GetSubjects(), code);

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
            else
            {
                Console.WriteLine("Student not found or not assigned to a degree!");
            }
        }
    }
}
