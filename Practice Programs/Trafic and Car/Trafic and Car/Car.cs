using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trafic_and_Car
{
    internal class Car
    {
        public string carName;  
        public Car(string name)  
        {
            carName = name;
        }
        public void onSignalChange(string action) 
        {
            Console.WriteLine("I am " + carName + " and I am in " + action + " state");
        }

    }

}
