using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyPattern
{
    internal class MotoStrategy : IStrategy
    {
        public void Run()
        {
            Console.WriteLine("Moto is running with 2 wheels");
        }
    }
}
