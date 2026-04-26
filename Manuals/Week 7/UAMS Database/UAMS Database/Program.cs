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
                    //Load from database instead of checking in-memory list
                    List<DegreeProgramBL> allPrograms = DegreeProgramDL.GetAllDegreePrograms();

                    if (allPrograms.Count == 0)
                    {
                        Console.WriteLine("No degree programs available. Please add a degree program first.");
                    }
                    else
                    {
                        //Also update programList so StudentUI can show them
                        DegreeProgramDL.programList = allPrograms;
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

                    //Search from database instead of in-memory list
                    List<DegreeProgramBL> allPrograms = DegreeProgramDL.GetAllDegreePrograms();
                    DegreeProgramBL deg = allPrograms.Find(d => d.GetTitle() == title);

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
                    List<StudentBL> studentList = StudentDL.GetAllStudents();

                    foreach (StudentBL s in studentList)
                        s.CalculateMerit();

                    for (int i = 0; i < studentList.Count - 1; i++)
                        for (int j = 0; j < studentList.Count - 1 - i; j++)
                            if (studentList[j].GetMerit() < studentList[j + 1].GetMerit())
                            {
                                StudentBL temp = studentList[j];
                                studentList[j] = studentList[j + 1];
                                studentList[j + 1] = temp;
                            }

                    foreach (StudentBL s in studentList)
                        foreach (DegreeProgramBL d in s.GetPreferences())
                            if (d.GetSeats() > 0 && s.GetRegDegree() == null)
                            {
                                s.SetRegDegree(d);
                                d.SetSeats(d.GetSeats() - 1);
                                StudentDL.UpdateRegDegree(s.GetName(), d.GetTitle());
                                break;
                            }

                    StudentUI.PrintMeritList(studentList);
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
