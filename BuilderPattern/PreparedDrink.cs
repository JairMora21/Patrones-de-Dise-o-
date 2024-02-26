using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern
{
    public class PreparedDrink
    {
        public List<string> Ingredients =  new List<string>();
        public int Milk;
        public int Alchol;
        public int Water;

        //Quitamos el constructor 
   

        public string Result;
    }
}
