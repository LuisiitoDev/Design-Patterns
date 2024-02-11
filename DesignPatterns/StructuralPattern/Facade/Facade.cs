using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPattern.Facade
{
    public class Facade
    {
        private Subsystem1 subsystem1;
        private Subsystem2 subsystem2;

        public Facade()
        {
            subsystem1 = new Subsystem1();
            subsystem2 = new Subsystem2();
        }

        // Métodos que encapsulan operaciones complejas utilizando los subsistemas.
        public void Operation()
        {
            Console.WriteLine("Facade: Operación");
            subsystem1.Operation1();
            subsystem1.Operation2();
            subsystem2.Operation1();
            subsystem2.Operation2();
        }
    }
}