using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using UAMS_3_layers.BL;
using UAMS_3_layers.DL;
using UAMS_3_layers.UI;


namespace UAMS_3_layers
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
                        StudentDL.AddStudent(StudentUI.takeInputForStudent());
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

                    DegreeProgramBL deg = DegreeProgramDL.programList.Find(d => d.title == title);

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

                    for (int i = 0; i < StudentDL.studentList.Count - 1; i++)       //finding the highest merit
                    {
                        for (int j = 0; j < StudentDL.studentList.Count - 1 - i; j++)
                        {
                            if (StudentDL.studentList[j].merit < StudentDL.studentList[j + 1].merit)
                            {
                                StudentBL temp = StudentDL.studentList[j];
                                StudentDL.studentList[j] = StudentDL.studentList[j + 1];
                                StudentDL.studentList[j + 1] = temp;
                            }
                        }
                    }

                    foreach (StudentBL s in StudentDL.studentList)
                    {
                        foreach (DegreeProgramBL d in s.prefrences)
                        {
                            if (d.seats > 0 && s.RegDegree == null)
                            { 
                                s.RegDegree = d; d.seats--; break; 
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

                else if (choice == 9)
                {

                }


                ConsoleUtility.Pause();
            }
            while (choice != 9);
        }

    }
}
