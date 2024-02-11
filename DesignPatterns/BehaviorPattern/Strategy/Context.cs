using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviorPattern.Strategy
{
    public class Context
    {
        private IStrategy strategy;

        public Context(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        // Método para cambiar la estrategia en tiempo de ejecución
        public void ChangeStrategy(IStrategy newStrategy)
        {
            this.strategy = newStrategy;
        }

        // Método que utiliza la estrategia actual
        public void ExecuteStrategy()
        {
            strategy.Execute();
        }
    }
}