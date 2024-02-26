using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryPattern
{
    //Creator
    //La clase abstracta que define el método que se va a implementar en las subclases
    public abstract class SaleFactory
    {
        public abstract ISale GetSale();
    }

    //ConcreteCreator
    //Las subclases que implementan el método de la clase abstracta
    public class StoreSaleFactory : SaleFactory
    {
        //Se añade un parámetro extra para el método de la clase StoreSale
        private decimal _extra;
        public StoreSaleFactory(decimal extra)
        {
            _extra = extra;
        }
        //Se implementa el método de la clase abstracta y retorna una instancia de la clase StoreSale
        public override ISale GetSale()
        {
            return new StoreSale(_extra);
        }
    }

    //Internet Sale Factory
    public class InternetSaleFactory : SaleFactory
    {
        private decimal _discount;
        public InternetSaleFactory(decimal discount)
        {
            _discount = discount;
        }
        public override ISale GetSale()
        {
            return new InternetSale(_discount);
        }
    }

    //Concrete Product
    //Las clases que implementan el método de la interfaz
    public class StoreSale : ISale
    {
        //Se añade un parámetro extra para el método de la clase StoreSale
        private decimal _extra;
        public StoreSale(decimal extra)
        {
            _extra = extra;
        }
        //Se implementa el método de la interfaz
        public void Sell(decimal total)
        {
            Console.WriteLine("Total TIENDA: " + (total + _extra));
        }
    }

    // Internet Sale
    public class InternetSale : ISale
    {
        private decimal _discount;
        public InternetSale(decimal discount)
        {
            _discount = discount;
        }
        public void Sell(decimal total)
        {
            Console.WriteLine("Total INTERNET: " + (total - _discount));
        }
    }

    //Product
    //La interfaz que define el método que se va a implementar en las clases
    public interface ISale
    {
        public void Sell(decimal total);
    }
}
