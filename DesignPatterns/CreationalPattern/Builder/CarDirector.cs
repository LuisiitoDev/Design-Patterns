using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPattern.Builder
{
    class CarDirector
    {
        private ICarBuilder carBuilder;

        public CarDirector(ICarBuilder builder)
        {
            carBuilder = builder;
        }

        public void ConstructCar()
        {
            carBuilder.SetModel();
            carBuilder.SetEngine();
            carBuilder.SetTransmission();
            carBuilder.SetColor();
        }
    }
}