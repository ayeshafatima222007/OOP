using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;

namespace Polymorphism_and_Animals
{
    internal class Cat : Animal
    {
        public Cat (string name) : base (name)
        {
            //name is handled by base class
        }

        public void greets()
        {
            Console.WriteLine("Meow");
        }

        // Override ToString to provide a string representation
        public override string ToString()
        {
            return $"Cat {base.toString()}";
        }
    }
}
