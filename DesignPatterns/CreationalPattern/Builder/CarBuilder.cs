using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPattern.Builder
{
    class CarBuilder : ICarBuilder
    {
        private Car car = new Car();

        public void SetModel()
        {
            car.Model = "Sedan";
        }

        public void SetEngine()
        {
            car.Engine = "V6";
        }

        public void SetTransmission()
        {
            car.Transmission = "Automatic";
        }

        public void SetColor()
        {
            car.Color = "Blue";
        }

        public Car GetCar()
        {
            return car;
        }
    }
}