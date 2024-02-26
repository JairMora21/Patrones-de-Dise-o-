using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern
{
    public class BarmanDirector
    {
        private IBuilder _builder;

        public BarmanDirector(IBuilder builder)
        {
            _builder = builder;
        }

        public void MakeMargarita()
        {
            _builder.Reset();
            _builder.AddWater(100);
            _builder.AddAlcohol(10);
            _builder.AddIngredients("Lemon");
            _builder.AddIngredients("Salt");
            _builder.AddIngredients("Tequila");
            _builder.Mix();
        }

        public void MakeMichelada()
        {
            _builder.Reset();
            _builder.AddWater(100);
            _builder.AddAlcohol(10);
            _builder.AddIngredients("Lemon");
            _builder.AddIngredients("Salt");
            _builder.AddIngredients("Beer");
            _builder.Mix();
        }
    }
}
