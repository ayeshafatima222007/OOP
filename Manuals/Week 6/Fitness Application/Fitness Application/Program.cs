using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************");
            Console.WriteLine("*    Fitness Application  *");
            Console.WriteLine("***************************");

            Console.Write("Enter Workout Name: ");
            string WName = Console.ReadLine();

            WorkoutRoutine w = new WorkoutRoutine(WName);

            int ExNo;
            while (true)
            {
                Console.Write($"Enter the No. of exercises you want to add in {WName} workout: ");
                if (int.TryParse(Console.ReadLine(), out ExNo))
                {
                    break;
                }
                else
                {
                    Console.Write("Enter a valid number!!\n");
                }
            }

            for (int i = 0; i < ExNo; i++)
            {
                Console.Write("Enter Exercise Name: ");
                string ExName = Console.ReadLine();

                Exercise e = new Exercise(ExName);

                int SetNo;
                while (true)
                {
                    Console.Write($"Enter the No. of sets you want to add in {ExName} exercise: ");
                    if (int.TryParse(Console.ReadLine(), out SetNo))
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Enter a valid number!!");
                    }
                }

                for (int j = 0; j < SetNo; j++)
                {
                    int Rep;
                    while (true)
                    {
                        Console.Write($"Enter the No. of repititions : ");
                        if (int.TryParse(Console.ReadLine(), out Rep))
                        {
                            break;
                        }
                        else
                        {
                            Console.Write("Enter a valid number!!");
                        }
                    }

                    double Weight;
                    while (true)
                    {
                        Console.Write($"Enter the total weight : ");
                        if (double.TryParse(Console.ReadLine(), out Weight))
                        {
                            break;
                        }
                        else
                        {
                            Console.Write("Enter a valid number!!");
                        }
                    }

                    Set s = new Set(Rep, Weight);

                    e.AddSet(s);

                }

                w.AddExercise(e);


            }

            Console.WriteLine("**** WORKOUT ROUTINE ****");
            //displaying output    
            foreach (Exercise e in w.getExercises())      // Loop through exercises in routine
            {
                Console.WriteLine($"The exercises are {e.getExrName()}");

                foreach (Set s in e.getSets())            // Loop through sets in exercise
                {
                    Console.WriteLine($"The repititions are {s.getReps()}");
                    Console.WriteLine($"The weight is {s.getWeight()}");
                }
            }


        }
    }
}
