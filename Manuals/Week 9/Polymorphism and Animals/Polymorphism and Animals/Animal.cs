using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_and_Animals
{
    internal class Animal
    {
        private string name;

        public Animal(string name)
        {
            this.name = name;
        }

        public string toString()
        {
            return $"Animal[name={name}]";
        }
    }
}
