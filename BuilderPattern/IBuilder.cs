using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern
{
    public interface IBuilder
    {
        //Esto es para que el objeto pueda regrearlo a una creacion en blanco
        public void Reset();
        public void AddWater(int water);
        public void AddMilk(int milk);
        public void AddAlcohol(int alcohol);
        public void AddIngredients(string ingredients);
        public void Mix();
        public void Rest(int time);
    }
}
