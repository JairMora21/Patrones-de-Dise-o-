using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DependencyInjection
{
    public class Beer
    {
        private string _name;
        private string _brand;
        private string _alchol;

        public string Name
        {
            get { return _name; }
        }

        public Beer (string name, string brand, string alchol)
        {
            _name = name;
            _brand = brand;
            _alchol = alchol;
        }
    }
}
