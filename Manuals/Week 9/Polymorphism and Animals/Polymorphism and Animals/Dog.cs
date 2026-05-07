using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_and_Animals
{
    internal class Dog : Animal
    {
        public Dog(string name) : base(name) { }

        public virtual void greets()
        {
            Console.WriteLine("Woof");
        }

        // Overloaded method: different signature (takes a Dog parameter)
        public void greets(Dog another)
        {
            Console.WriteLine("Woooof");
        }

        public override string ToString()
        {
            return $"Dog[{base.ToString()}]";
        }
    }
}
