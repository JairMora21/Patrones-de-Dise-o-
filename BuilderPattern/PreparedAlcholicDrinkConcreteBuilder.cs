using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern
{
    public class PreparedAlcholicDrinkConcreteBuilder : IBuilder
    {
        //Creamos un objeto de tipo PreparedDrink
        private PreparedDrink _preparedDrink;

        //Inicializamos el objeto
        public PreparedAlcholicDrinkConcreteBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._preparedDrink = new PreparedDrink();
        }

        public void AddWater(int water)
        {
            this._preparedDrink.Water = water;
        }

        public void AddMilk(int milk)
        {
            this._preparedDrink.Milk = milk;
        }

        public void AddAlcohol(int alcohol)
        {
            this._preparedDrink.Alchol = alcohol;
        }

        public void AddIngredients(string ingredients)
        {
            if (_preparedDrink.Ingredients == null)
            {
                _preparedDrink.Ingredients = new List<string>();
            }

            _preparedDrink.Ingredients.Add(ingredients);
        }

        public void Mix()
        {
            string ingredients = _preparedDrink.Ingredients.Any()
                ? _preparedDrink.Ingredients.Aggregate((i, j) => i + ", " + j)
                : string.Empty;
            _preparedDrink.Result = $"Mezclando {_preparedDrink.Water}ml de agua, {_preparedDrink.Milk}ml de leche, {_preparedDrink.Alchol}ml de alcohol y {ingredients}";
            Console.WriteLine("Mezclamos los ingredientes");
        }

        public void Rest(int time)
        {
            Thread.Sleep(time);
            Console.WriteLine("Listo para beber");
        }

        public PreparedDrink GetPreparedDrink()
        {
            PreparedDrink result = this._preparedDrink;
            this.Reset();
            return result;
        }


    }


}
    
