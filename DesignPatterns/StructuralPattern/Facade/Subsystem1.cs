using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPattern.Facade
{
    public class Subsystem1
    {
        public void Operation1()
        {
            Console.WriteLine("Subsystem 1: Operación 1");
        }

        public void Operation2()
        {
            Console.WriteLine("Subsystem 1: Operación 2");
        }
    }
}