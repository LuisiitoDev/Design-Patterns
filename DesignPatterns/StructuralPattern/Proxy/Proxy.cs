using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPattern.Proxy
{
public class Proxy : ISubject
{
    private RealSubject realSubject;

    public void Request()
    {
        // Utilizando un sujeto real sólo cuando sea necesario.
        if (realSubject == null)
        {
            realSubject = new RealSubject();
        }

        // El proxy puede realizar operaciones adicionales antes o después de llamar al sujeto real.
        Console.WriteLine("Proxy: Antes de realizar la petición.");

        // Llamando al sujeto real.
        realSubject.Request();

        Console.WriteLine("Proxy: Después de realizar la petición.");
    }
}
}