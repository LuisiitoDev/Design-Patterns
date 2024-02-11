using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPattern.Factory
{
    interface IFactory
    {
        IProduct CreateProduct();
    }
}