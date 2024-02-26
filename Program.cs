using DesignPatterns.BuilderPattern;
using DesignPatterns.FactoryPattern;
using DesignPatterns.Models;
using DesignPatterns.RepositoryPattern;
using DesignPatterns.Singelton;
using DesignPatterns.StatePattern;
using DesignPatterns.StrategyPattern;
using DesignPatterns.UnitOfWorkPattern;
using Microsoft.EntityFrameworkCore;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Poner el código aquí
        }
    }
}

//SINGLETON

//var singleton1 = Singleton.Instance;
//var singleton2 = Singleton.Instance;
//Console.WriteLine(singleton1 == singleton2);
//OUTPUT: True


//FACTORY PATTERN

// Podemos crear una instancia a storeSaleFactory porque hereda de SaleFactory
// ambas implementan el método GetSale pero con diferentes comportamientos
//SaleFactory storeSaleFactory = new StoreSaleFactory(10);
//SaleFactory internetSaleFactory = new InternetSaleFactory(2);

/*No necesitamos mandar parámetros a la clase StoreSale o InternetSale
ya que los parámetros se pasaron al crear la instancia de StoreSaleFactory o InternetSaleFactory */

//ISale sale1 = storeSaleFactory.GetSale();
//sale1.Sell(100);
//OUTPUT:  Total TIENDA: 110

//ISale sale2 = internetSaleFactory.GetSale();
//sale2.Sell(100);
//OUTPUT:  Total INTERNET: 98

//INYECCION DE DEPENDENCIAS

//var beer = new Beer("Corona", "Corona", "4.5");
//var drinkWithBeer = new DrinkWithBeer("1L", "10g", beer);
//drinkWithBeer.Build();
//OUTPUT: Preparando bebida que tiene agua 1Lazucar 10g y Corona

//REPOSITORIO

//Creando el contexto
//using (var context = new DesingPatternsContext())
//{
//    //Creando el repositorio
//    var beerRepository = new BeerRepository(context);
//    //Insertando datos y guardando
//    beerRepository.InsertBeer(new Beer { BeerId = 3, Name = "Victoria", Style = "Miche" });
//    beerRepository.Save();

//    //Obteniendo datos
//    var beers = beerRepository.GetBeers();
//    foreach (var beer in beers)
//    {
//        Console.WriteLine(beer.Name);
//        //OUTPUT: Minerva, Corona, Victoria
//    }

//}

//using (var context = new DesingPatternsContext())
//{
//    //Creando el repositorio de cervezas
//    var beerRepository = new Repository<Beer>(context);
//    beerRepository.Insert(new Beer { Name = "Victoria", Style = "Miche" });
//    beerRepository.Save();

//    var beers = beerRepository.GetAll();
//    foreach (var beer in beers)
//    {
//        Console.WriteLine(beer.Name);
//        //OUTPUT: Minerva, Corona, Victoria
//    }
//    //Creando el repositorio de marcas
//    var brandRepository = new Repository<Brand>(context);
//    brandRepository.Insert(new Brand { Name = "Corona" });
//    brandRepository.Save();

//    var brands = brandRepository.GetAll();
//    foreach (var brand in brands)
//    {
//        Console.WriteLine(brand.Name);
//        //OUTPUT: Minerva, Corona
//    }
//}

//UNIT OF WORK

//using (var context = new DesingPatternsContext())
//{
//    //Creando el repositorio UnitOfWork
//    var unitOfWork = new UnitOfWork(context);

//    //Creamos un objeto de tipo cerveza y lo insertamos
//    var beers = unitOfWork.Beers;
//    var beer = new Beer { Name = "Fuller", Style = "Nose" };
//    beers.Insert(beer);

//    //Creamos un objeto de tipo marca y lo insertamos
//    var brands = unitOfWork.Brands;
//    var brand = new Brand { Name = "Ultra" };
//    brands.Insert(brand);

//    //Guardamos los cambios de ambas tablas
//    //unitOfWork.Save();

//}


////STRATEGY PATTERN

//var context = new Context(new CarStrategy());
//context.Run();
////OUTPUT: Car is running with 4 wheels
//context.Strategy = new MotoStrategy();
//context.Run();
////OUTPUT: Moto is running with 2 wheels
///

////BUILDER PATTERN

//var builder = new PreparedAlcholicDrinkConcreteBuilder();
//var director = new BarmanDirector(builder);
//director.MakeMargarita();

//var preparedDrink = builder.GetPreparedDrink();
//Console.WriteLine(preparedDrink.Result);
////OUTPUT: Mezclando 100ml de agua, 0ml de leche, 10ml de alcohol y Lemon, Salt, Tequila


////STATE PATTERN

//var customerContext = new CustomerContext();
//Console.WriteLine("Estado actual: " + customerContext.GetState());
////OUTPUT: Estado actual: DesignPatterns.StatePattern.NewState

//customerContext.Request(100);
////OUTPUT: Se le pone dinero a su saldo 100

//Console.WriteLine("Estado actual: " + customerContext.GetState());
////OUTPUT: Estado actual: DesignPatterns.StatePattern.NotDebtorState

//customerContext.Request(50);
////OUTPUT: Solicitud permitida, gasta 50 y le queda saldo de 50

//Console.WriteLine("Estado actual: " + customerContext.GetState());
////OUTPUT: Estado actual: DesignPatterns.StatePattern.NotDebtorState

//customerContext.Request(60);
////OUTPUT: No tiene saldo suficiente, saldo actual 50