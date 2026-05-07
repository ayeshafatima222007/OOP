using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_and_Animals
{
    internal class Mammal : Animal
    {
        public Mammal(string name) : base (name)
        { 
            //name is handled by base class
        }

        public override string ToString()
        {
            return $"Mammal[{base.ToString()}]";
        }
    }
}
