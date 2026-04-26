using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS_Database.BL;
using UAMS_Database.DL;
using UAMS_Database.UI;

namespace UAMS_Database
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;

            do
            {
                choice = ConsoleUtility.ShowMenu();

                if (choice == 1)
                {
                    if (DegreeProgramDL.programList.Count == 0)
                    {
                        Console.WriteLine("No degree programs available. Please add a degree program first.");
                    }
                    else
                    {
                        StudentDL.AddStudent(StudentUI.TakeInputForStudent());
                    }
                }

                else if (choice == 2)
                {
                    DegreeProgramDL.AddDegreeProgram(DegreeProgramUI.TakeDegreeProgramInput());
                }

                else if (choice == 3)
                {
                    Console.Write("Enter Degree Title: ");
                    string title = Console.ReadLine();

                    DegreeProgramBL deg = DegreeProgramDL.programList.Find(d => d.GetTitle() == title);

                    if (deg != null)
                    {
                        DegreeProgramUI.AddSubjectToDegree(deg);
                    }
                    else
                    {
                        Console.WriteLine("Degree not found!");
                    }
                }

                else if (choice == 4)
                {
                    foreach (StudentBL s in StudentDL.studentList)
                    {
                        s.CalculateMerit();
                    }

                    for (int i = 0; i < StudentDL.studentList.Count - 1; i++)
                    {
                        for (int j = 0; j < StudentDL.studentList.Count - 1 - i; j++)
                        {
                            if (StudentDL.studentList[j].GetMerit() < StudentDL.studentList[j + 1].GetMerit())
                            {
                                StudentBL temp = StudentDL.studentList[j];
                                StudentDL.studentList[j] = StudentDL.studentList[j + 1];
                                StudentDL.studentList[j + 1] = temp;
                            }
                        }
                    }

                    foreach (StudentBL s in StudentDL.studentList)
                    {
                        foreach (DegreeProgramBL d in s.GetPreferences())
                        {
                            if (d.GetSeats() > 0 && s.GetRegDegree() == null)
                            {
                                s.SetRegDegree(d);
                                d.SetSeats(d.GetSeats() - 1);
                                break;
                            }
                        }
                    }

                    StudentUI.PrintMeritList(StudentDL.studentList);
                }

                else if (choice == 5)
                {
                    StudentDL.ViewRegisteredStudents();
                }

                else if (choice == 6)
                {
                    Console.Write("Enter Degree Name: ");
                    string name = Console.ReadLine();
                    StudentDL.ViewStudentsInDegree(name);
                }

                else if (choice == 7)
                {
                    Console.Write("Enter Student Name: ");
                    string name = Console.ReadLine();
                    StudentBL s = StudentDL.FindByName(name);
                    StudentUI.RegisterSubjects(s);
                }

                else if (choice == 8)
                {
                    StudentDL.CalculateFeeForAll();
                }

                ConsoleUtility.Pause();
            }
            while (choice != 9);
        }
    }
}
