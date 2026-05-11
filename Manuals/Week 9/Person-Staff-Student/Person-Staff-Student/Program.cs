using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Staff_Student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            // Create 2 Students
            people.Add(new Student("Alice", "123 Maple St", "CS", 2024, 15000));
            people.Add(new Student("Bob", "456 Oak Rd", "Engineering", 2025, 16500));

            // Create 2 Staff
            people.Add(new Staff("Mrs. Smith", "789 Pine Ave", "Greenwood High", 55000));
            people.Add(new Staff("Mr. Jones", "321 Birch Blvd", "Riverdale College", 62000));

            // Print information using the overridden ToString()
            Console.WriteLine("--- School Database ---");
            foreach (Person p in people)
            {
                Console.WriteLine(p.ToString());
                Console.WriteLine();
            }
        }
    }
}
