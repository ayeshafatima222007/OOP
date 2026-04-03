using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trafic_and_Car
{
    internal class TrafficSignal
    {
        string state;
        List<Car> carList = new List<Car>();

        public void addCar(Car c)
        {
            carList.Add(c);
        }
        public void setRedState()
        {
            state = "Red";
            informCars();
        }
        public void setGreenState()
        {
            state = "Green";
            informCars();
        }
        public void informCars()
        {
            foreach (Car car in carList)
            {
                car.onSignalChange(state);
            }
        }
    }
}