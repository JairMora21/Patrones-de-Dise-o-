using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DependencyInjection
{
    internal class DrinkWithBeer
    {
        //No lo instanciamos definiendolo
        private Beer _beer;
        private string _water;
        private string _sugar;

        //Lo ponemos en el constructor
        public DrinkWithBeer(string water, string sugar, Beer beer)
        {
            _water = water;
            _sugar = sugar;
            _beer = beer;
        }

        public void Build()
        {
            Console.WriteLine($"Preparando bebida que tiene agua {_water}" +
                $"azucar {_sugar} y {_beer.Name}");
        }
    }
}
