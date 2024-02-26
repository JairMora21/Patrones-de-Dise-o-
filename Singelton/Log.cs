using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singelton
{
    internal class Log
    {
        private readonly static Log _instance = new Log();
        //Crea un archivo log.txt en la raiz del proyecto
        private string _path = "log.txt";
        //Propiedad que devuelve la instancia de la clase
        public static Log Instance
        {
            get
            {
                return _instance;
            }
        }
        private Log()
        {
        }
        //Guarda un mensaje en el archivo log.txt
        public void Save(string message)
        {
            File.AppendAllText(_path, message + Environment.NewLine);
        }
    }
}
