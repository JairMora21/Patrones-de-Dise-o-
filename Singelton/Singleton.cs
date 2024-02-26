using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singelton
{
    internal class Singleton
    {
        //Asi se crea un singleton
        private readonly static Singleton _instance = new Singleton();

        //Asi se accede al singleton
        public static Singleton Instance
        {
            get
            {
                return _instance;
            }
        }
        //El constructor es privado para que no se pueda instanciar
        private Singleton()
        {
        }
    }
}
