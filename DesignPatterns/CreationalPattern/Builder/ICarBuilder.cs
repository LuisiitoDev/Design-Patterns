using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPattern.Builder
{
    interface ICarBuilder
    {
        void SetModel();
        void SetEngine();
        void SetTransmission();
        void SetColor();
        Car GetCar();
    }
}