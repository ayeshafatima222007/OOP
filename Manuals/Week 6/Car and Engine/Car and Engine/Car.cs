using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_and_Engine
{
    internal class Car
    {
        public Engine engine;

        public Car(Engine engine)
        {
            this.engine = engine;
        }

        public void Crash()
        {
            Console.WriteLine($"Car is destroyed including the engine ({engine.type})");
        }
    }
}
