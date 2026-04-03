using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_and_Engine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Engine engine = new Engine("Audi");
            Car car = new Car(engine);
            car.Crash();

        }
    }
}
