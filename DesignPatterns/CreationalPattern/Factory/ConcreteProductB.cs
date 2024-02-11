using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPattern.Factory
{
    class ConcreteProductB : IProduct
    {
        public void Operation()
        {
            Console.WriteLine("Operation in ConcreteProductB");
        }
    }
}