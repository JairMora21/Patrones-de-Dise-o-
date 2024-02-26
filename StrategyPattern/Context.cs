using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyPattern
{
    public class Context
    {
        
        private IStrategy _strategy;

        //Podemos cambiar la estrategia en tiempo de ejecución
        public IStrategy   Strategy
        {
            set { _strategy = value; }
        }

        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        //Ejecutamos la estrategia
        public void Run()
        {
            _strategy.Run();
        }
    }
}
