using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trafic_and_Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TrafficSignal signal1 = new TrafficSignal();
            Car car1 = new Car("Car1");
            Car car2 = new Car("Car2");
            signal1.addCar(car1);
            signal1.addCar(car2);
            signal1.setRedState();
            signal1.setGreenState();
            Console.ReadKey();
        }
    }
}
