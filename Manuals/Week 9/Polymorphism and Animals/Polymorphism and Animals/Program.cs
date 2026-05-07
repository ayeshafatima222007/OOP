using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_and_Animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create 2 Cat objects
            Cat cat1 = new Cat("Luna");
            Cat cat2 = new Cat("Milo");


            // Create 2 Dog objects
            Dog dog1 = new Dog("Rocky");
            Dog dog2 = new Dog("Bella");

            Console.WriteLine("--- Greets ---\n");


            // Executing Cat 1
            cat1.greets();
            Console.WriteLine(cat1.ToString());
            Console.WriteLine();

            // Executing Cat 2
            cat2.greets();
            Console.WriteLine(cat2.ToString());
            Console.WriteLine();

            // Executing Dog 1
            dog1.greets();
            Console.WriteLine(dog1.ToString());
            Console.WriteLine();

            // Executing Dog 2
            dog2.greets();
            Console.WriteLine(dog2.ToString());
        }
    }

}